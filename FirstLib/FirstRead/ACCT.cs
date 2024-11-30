using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FirstLib.IO;

namespace FirstLib.FirstRead
{

    public enum ACCTPathMode
    {
        Unpacked,
        Packed
    }
    // structure figured out by korenkonder
    public class ACCTPath
    {
        public String FilePath;
        public String FileName;
        public ACCTPathMode Flags;

        public void Read(XReader reader, int strOffset)
        {
            int filePathPos = reader.ReadInt32();
            int fileNamePos = reader.ReadInt32();
            Flags = (ACCTPathMode)reader.ReadInt32();
            FilePath = reader.ReadStringAtOffset(strOffset + filePathPos, StringFormat.NullTerminated);
            FileName = reader.ReadStringAtOffset(strOffset + fileNamePos, StringFormat.NullTerminated);
        }
    }
    public class ACCT
    {
        public XHeader Header;
        public int U00;
        public int ContainerID;
        public short U08;
        public List<ACCTPath> Paths { get; }
        public List<string> ObjsetFlist;
        public List<string> Auth2DFlist;
        public string ContainerName;
        public List<PRDB> ParameterDatabases;
        public List<RBDB> RobDatabases;
        public List<STRA> StringArrays;
        public List<RGHT> RightsTables;

        public void Read(XReader reader)
        {
            Header = new XHeader();
            Header.Read(reader);
            if (Header.Signature[0] != 'A' && Header.Signature[1] != 'C' && Header.Signature[2] != 'C' && Header.Signature[3] != 'T')
                throw new InvalidDataException("Invalid file.");
            reader.UpdateBasePosition();
            U00 = reader.ReadInt32();
            ContainerID = reader.ReadInt32();
            U08 = reader.ReadInt16();
            int pathCount = reader.ReadInt16();
            int objCount = reader.ReadInt16();
            int aetCount = reader.ReadInt16();
            long pathOffset = reader.ReadInt64();
            long objOffset = reader.ReadInt64();
            long aetOffset = reader.ReadInt64();
            long strOffset = reader.ReadInt64();
            ContainerName = reader.ReadString(StringFormat.FixedLength, 0x60);
            // paths
            reader.ReadAtOffset((int)pathOffset, () =>
            {
                for (int i = 0; i < pathCount; i++)
                {
                    ACCTPath path = new ACCTPath();
                    path.Read(reader, (int)strOffset);
                    Paths.Add(path);
                }
            });
            // objects
            reader.ReadAtOffset((int)objOffset, () => 
            {
                for (int i = 0; i < objCount; i++)
                {
                    int namePos = reader.ReadInt32();
                    ObjsetFlist.Add(reader.ReadStringAtOffset((int)(namePos + strOffset), StringFormat.NullTerminated));
                }
            });
            // Auth2D
            reader.ReadAtOffset((int)aetOffset, () =>
            {
                for (int i = 0; i < aetCount; i++)
                {
                    int namePos = reader.ReadInt32();
                    Auth2DFlist.Add(reader.ReadStringAtOffset((int)(namePos + strOffset), StringFormat.NullTerminated));
                }
            });
            // we have all data, pass the footers
            reader.Seek(Header.DataSize, XSeekOrigin.Base);
            // get past the possibility of ENRS
            char[] checkNextSection = reader.CheckNextSection();
            if (checkNextSection[0] == 'E')  // probably enough to make a guess
            {
                reader.SkipNextSection();
            }
            // then the POF1 which is guaranteed
            reader.SkipNextSection();
            Console.WriteLine("ACCT Read");
            // now check for, and currently skip, other sections
            while (true)
            {
                char[] check = reader.CheckNextSection();
                Console.WriteLine(new string(check));
                if (check[0] == 'P' && check[1] == 'R' && check[2] == 'D' && check[3] == 'B')
                {
                    PRDB paramDB = new PRDB();
                    paramDB.Read(reader);
                    ParameterDatabases.Add(paramDB);
                }
                else if (check[0] == 'R' && check[1] == 'B' && check[2] == 'D' && check[3] == 'B')
                {
                    RBDB robDatabase = new RBDB();
                    robDatabase.Read(reader);
                    RobDatabases.Add(robDatabase);
                }
                else if (check[0] == 'S' && check[1] == 'T' && check[2] == 'R' && check[3] == 'A')
                {
                    STRA stringArray = new STRA();
                    stringArray.Read(reader);
                    StringArrays.Add(stringArray);
                }
                else if (check[0] == 'R' && check[1] == 'G' && check[2] == 'H' && check[3] == 'T')
                {
                    RGHT rights = new RGHT();
                    rights.Read(reader);
                    RightsTables.Add(rights);
                }
                else if (check[0] == 'E' && check[1] == 'O' && check[2] == 'F' && check[3] == 'C')
                {
                    reader.SkipNextSection();  // the ACCT eofc that is
                    break;
                }
            }
        }

        public void Write(XWriter writer)
        {
            writer.WriteHeader(new char[4] {'A', 'C', 'C', 'T'});
            long basePos = writer.Tell();
            writer.Write(U00);
            writer.Write(ContainerID);
            writer.Write(U08);
            writer.Write((short)Paths.Count());
            writer.Write((short)ObjsetFlist.Count());
            writer.Write((short)Auth2DFlist.Count());
            // paths offset
            long pathPos = writer.Tell();
            writer.Write((long)0);
            // objs offset
            //long objPos = writer.Tell();
            writer.Write((long)0);
            // aets offset
            //long aetPos = writer.Tell();
            writer.Write((long)0);
            // strs offset 
            //long strPos = writer.Tell();
            writer.Write((long)0);
            writer.WriteString(ContainerName, StringFormat.FixedLength, 0x60);
            // generate the path table
            int baseStrPos = 0;
            List<int> stringPositions = new List<int>();
            List<string> strings = new List<string>();
            long pathOffset = writer.Tell();
            foreach (var path in Paths)
            {
                if (strings.Contains(path.FilePath))
                {
                    writer.Write(stringPositions[strings.IndexOf(path.FilePath)]);
                }
                else
                {
                    stringPositions.Add(baseStrPos);
                    strings.Add(path.FilePath);
                    writer.Write(baseStrPos);
                    baseStrPos += Encoding.UTF8.GetByteCount(path.FilePath) + 1;
                }
                // repeat with FileName
                if (strings.Contains(path.FileName))
                {
                    writer.Write(stringPositions[strings.IndexOf(path.FileName)]);
                }
                else
                {
                    stringPositions.Add(baseStrPos);
                    strings.Add(path.FileName);
                    writer.Write(baseStrPos);
                    baseStrPos += Encoding.UTF8.GetByteCount(path.FileName) + 1;
                }
                writer.Write((int)path.Flags);
            }
            writer.Align(16);
            // the flists are simpler since their contents must exist in paths
            // but because i don't want to deal with this program crashing if a user gets this wrong
            // let's overdo it
            long objOffset = writer.Tell();
            foreach (var flistEntry in ObjsetFlist)
            {
                if (strings.Contains(flistEntry))
                {
                    writer.Write(stringPositions[strings.IndexOf(flistEntry)]);
                }
                else
                {
                    stringPositions.Add(baseStrPos);
                    strings.Add(flistEntry);
                    writer.Write(baseStrPos);
                    baseStrPos += Encoding.UTF8.GetByteCount(flistEntry) + 1;
                }
            }
            writer.Align(16);
            long aetOffset = writer.Tell();
            foreach (var flistEntry in Auth2DFlist)
            {
                if (strings.Contains(flistEntry))
                {
                    writer.Write(stringPositions[strings.IndexOf(flistEntry)]);
                }
                else
                {
                    stringPositions.Add(baseStrPos);
                    strings.Add(flistEntry);
                    writer.Write(baseStrPos);
                    baseStrPos += Encoding.UTF8.GetByteCount(flistEntry) + 1;
                }
            }
            writer.Align(16);
            long strOffset = writer.Tell();
            foreach (var str in strings)
            {
                writer.WriteString(str, StringFormat.NullTerminated);
            }
            writer.Align(16);
            long dataEnd = writer.Tell();
            writer.Seek((int)pathPos, SeekOrigin.Begin);
            if (Paths.Count != 0)
                writer.WriteOffset(pathOffset - basePos, basePos);
            else
                writer.Seek(8, SeekOrigin.Current);
            if (ObjsetFlist.Count != 0)
                writer.WriteOffset(objOffset - basePos, basePos);
            else
                writer.Seek(8, SeekOrigin.Current);
            if (Auth2DFlist.Count != 0)
                writer.WriteOffset(aetOffset - basePos, basePos);
            else
                writer.Seek(8, SeekOrigin.Current);
            if (Paths.Count != 0 || ObjsetFlist.Count != 0 || Auth2DFlist.Count != 0) // realistically, strings only exist if any one of these aren't 0
                writer.WriteOffset(strOffset - basePos, basePos);
            else
                writer.Seek(8, SeekOrigin.Current);
            writer.Seek((int)dataEnd, SeekOrigin.Begin);
            // fun fact, this could come after the RBDBs, PRDBs, or STRAs
            // X isn't as picky about section orders as you'd expect
            writer.WritePOF1();

            // this is where PRDBs, RBDBs, then STRAs would be written
            foreach (var paramDatabase in ParameterDatabases)
            {
                paramDatabase.Write(writer);
            }
            foreach (var robDatabase in RobDatabases)
            {
                robDatabase.Write(writer);
            }
            foreach (var strArray in StringArrays)
            {
                strArray.Write(writer);
            }
            writer.WriteEOFC();
            long contentsEnd = writer.Tell();
            writer.Seek((int)basePos-28, SeekOrigin.Begin);
            writer.Write((int)(contentsEnd - basePos));
            writer.Seek(12, SeekOrigin.Current);
            writer.Write((int)(dataEnd - basePos));
            writer.Seek((int)contentsEnd, SeekOrigin.Begin);
        }

        public override string ToString()
        {
            return ContainerName;
        }

        public ACCT()
        {
            Paths = new List<ACCTPath>();
            ObjsetFlist = new List<String>();
            Auth2DFlist = new List<String>();
            ParameterDatabases = new List<PRDB>();
            RobDatabases = new List<RBDB>();
            StringArrays = new List<STRA>();
            RightsTables = new List<RGHT>();
        }
    }
}
