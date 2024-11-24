using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FirstLib.IO;
using System.Diagnostics.Eventing.Reader;

namespace FirstLib.FirstRead
{
    public class STRAReturn
    {
        public bool Successful;
        public string String;

        public STRAReturn(bool successful, string str)
        {
            Successful = successful;
            String = str;
        }
    }
    // structure figured out by korenkonder
    public class STRAString
    {
        public string String;
        public uint ID;
        public void Read(XReader reader, int strOffset)
        {
            int strPos = reader.ReadInt32();
            String = reader.ReadStringAtOffset(strPos + strOffset, StringFormat.NullTerminated);
            ID = reader.ReadUInt32();
        }
    }
    public class STRA
    {
        public XHeader Header;
        public List<STRAString> Strings;

        public void Read(XReader reader)
        {
            Header = new XHeader();
            Header.Read(reader);
            reader.UpdateBasePosition();
            long stringEntryOffset = reader.ReadInt64();
            long strOffset = reader.ReadInt64();
            int stringCount = reader.ReadInt32();
            // get the strings
            reader.ReadAtOffset((int)stringEntryOffset, () =>
            {
                for (int i = 0; i < stringCount; i++)
                {
                    STRAString str = new STRAString();
                    str.Read(reader, (int)strOffset);
                    Strings.Add(str);
                }
            });
            // then go to the end of the data
            reader.Seek(Header.DataSize, XSeekOrigin.Base);
            // get past the possibility of ENRS
            char[] checkNextSection = reader.CheckNextSection();
            if (checkNextSection[0] == 'E')  // probably enough to make a guess
            {
                reader.SkipNextSection();
            }
            // then the POF1 which is guaranteed
            reader.SkipNextSection();
            // and the EOFC
            reader.SkipNextSection();
        }
        public void Write(XWriter writer)
        {
            writer.WriteHeader(new char[4] {'S', 'T', 'R', 'A'});
            // strings offset. also conveniently doubles as a data start so we can avoid double variables
            long stringPos = writer.Tell();
            writer.Write((long)0);
            // pointless to grab the position here
            writer.Write((long)0);
            writer.Write(Strings.Count());
            writer.Align(16);
            writer.WriteNulls(32);
            // stringOffset here
            long stringOffset = writer.Tell();
            int baseStrPos = 0;
            Dictionary<string, int> stringTable = new Dictionary<string, int>();
            foreach (var str in Strings)
            {
                if (stringTable.TryGetValue(str.String, out int getPos))
                {
                    writer.Write(getPos);
                    writer.Write(str.ID);
                }
                else
                {
                    //stringPositions.Add(baseStrPos);
                    stringTable.Add(str.String, baseStrPos);
                    writer.Write(baseStrPos);
                    writer.Write(str.ID);
                    baseStrPos += Encoding.UTF8.GetByteCount(str.String) + 1;
                }
            }
            writer.Align(16);
            // strOffset
            long strOffset = writer.Tell();
            foreach (var str in stringTable)
            {
                writer.WriteString(str.Key, StringFormat.NullTerminated);
            }
            writer.Align(16);
            long dataEnd = writer.Tell();
            writer.Seek((int)stringPos, SeekOrigin.Begin);
            writer.WriteOffset(stringOffset-stringPos, stringPos);
            writer.WriteOffset(strOffset-stringPos, stringPos);
            writer.Seek((int)dataEnd, SeekOrigin.Begin);
            writer.WritePOF1();
            writer.WriteEOFC();
            long contentsEnd = writer.Tell();
            // seek back and write
            writer.Seek((int)stringPos - 28, SeekOrigin.Begin);
            writer.Write((int)(contentsEnd - stringPos));
            writer.Seek(12, SeekOrigin.Current);
            writer.Write(dataEnd - stringPos);
            writer.Seek((int)contentsEnd, SeekOrigin.Begin);
        }
        public string GetStringById(int id)
        {
            if (Strings.IndexOf(Strings.Find(x => x.ID == id)) != -1)
                return Strings.Find(x => x.ID == id).String;
            else
                return "";
        }
        public bool SetStringById(int id, string str)
        {
            if (Strings.IndexOf(Strings.Find(x => x.ID == id)) != -1)
            {
                Strings[Strings.IndexOf(Strings.Find(x => x.ID == id))].String = str;
                return true;
            }
            else
                return false;
        }

        public static string GetStringFromArraysById(int id, List<STRA> arrays)
        {
            Console.WriteLine(id);
            int cur = 0;
            foreach (var stra in arrays)
            {
                Console.WriteLine(cur);
                cur++;
                if (stra.Strings.Exists(x => x.ID == id))
                {
                    string r = stra.Strings.First(x => x.ID == id).String;
                    if (r == "")
                    {
                        continue;
                    }
                    else
                    {
                        return r;
                    }
                }
                else
                {
                    continue;
                }
            }
            return "";
        }

        public STRA()
        {
            Strings = new List<STRAString>();
        }
    }
}
