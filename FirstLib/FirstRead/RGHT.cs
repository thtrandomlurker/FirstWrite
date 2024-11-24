using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstLib.IO;
using System.Numerics;
using System.IO;
using FirstLib.FirstRead.Common;

namespace FirstLib.FirstRead
{
    // the PRDB
    public class RGHT
    {
        public XHeader Header;

        public int U00;
        public List<string> FileNames;

        public void Read(XReader reader)
        {
            Header = new XHeader();
            Header.Read(reader);
            // we wouldn't be here if the ACCT section read loop didn't find this, so no point checking the signature.
            reader.UpdateBasePosition();
            U00 = reader.ReadInt32();
            int fileCount = reader.ReadInt32();
            ulong filesOffset = reader.ReadUInt64();

            reader.Seek((int)filesOffset, XSeekOrigin.Base);

            for (int i = 0; i < fileCount; i++)
            {
                FileNames.Add(reader.ReadStringOffset(StringFormat.NullTerminated));
            }

            // end of file
            reader.Seek(Header.DataSize, XSeekOrigin.Base);
            char[] check = reader.CheckNextSection();
            // Skip ENRS if it's there
            if (check[0] == 'E')
            {
                reader.SkipNextSection();
            }
            // POF is always here.
            reader.SkipNextSection();
            // Same for EOFC;
            reader.SkipNextSection();
        }

        public void Write(XWriter writer)
        {
            writer.WriteHeader(new char[4] { 'P', 'R', 'D', 'B' });
            long dataPos = writer.Tell();
            writer.Write(U00);
            writer.Write(FileNames.Count);
            writer.WriteOffset(writer.Tell() + 0x48 - dataPos, dataPos);

            writer.WriteNulls(0x48);

            long offsPos = writer.Tell();
            writer.WriteNulls(16 * FileNames.Count);
            long baseOff = writer.Tell();
            writer.Seek((int)offsPos, SeekOrigin.Begin);

            foreach (var file in FileNames)
            {
                writer.WriteOffset(baseOff - dataPos, dataPos);
                writer.Write((long)0);
                baseOff += Encoding.ASCII.GetByteCount(file) + 1;
            }

            foreach (var file in FileNames)
            {
                writer.WriteString(file, StringFormat.NullTerminated);
            }
            writer.Align(16);


            // end of file
            long dataEnd = writer.Tell();
            writer.WritePOF1();
            writer.WriteEOFC();
            long contentsEnd = writer.Tell();
            writer.Seek((int)dataPos - 28, SeekOrigin.Begin);
            writer.Write((int)(contentsEnd - dataPos));
            writer.Seek(12, SeekOrigin.Current);
            writer.Write((int)(dataEnd - dataPos));
            writer.Seek((int)contentsEnd, SeekOrigin.Begin);

        }

        public RGHT()
        {
            FileNames = new List<string>();
        }
    }
}
