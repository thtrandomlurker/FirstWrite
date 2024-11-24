using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FirstLib.IO;

namespace FirstLib.FirstRead
{
    // structure figured out by korenkonder
    public enum ACPKType
    { 
        Patch = 0b000000001,
        DLC = 0b000000010,
        Base = 0b100000000
    }
    public class ACPK
    {
        public XHeader Header;

        public int U00;
        public short PackageID;
        public ACPKType PackageType;
        public string Description;
        public byte IsRequired;
        public byte U11;

        public void Read(XReader reader)
        {
            Header = new XHeader();
            Header.Read(reader);
            if (Header.Signature[0] != 'A' && Header.Signature[1] != 'C' && Header.Signature[2] != 'P' && Header.Signature[3] != 'K')
                throw new InvalidDataException("Invalid file.");
            reader.UpdateBasePosition();
            U00 = reader.ReadInt32();
            PackageID = reader.ReadInt16();
            PackageType = (ACPKType)reader.ReadInt16();
            Description = reader.ReadStringOffset(StringFormat.NullTerminated);
            IsRequired = reader.ReadByte();
            U11 = reader.ReadByte();
            // we have all the data so
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
            Dictionary<long, string> tempStrings = new Dictionary<long, string>();  // position of the string offset, string to write. since we loop through we can infer the position of the string later
            writer.WriteHeader(new char[4] { 'A', 'C', 'P', 'K' });  // to initialize this section
            // of course, we grab the base
            long basePos = writer.Tell();
            // then we do the data
            writer.Write(U00);
            writer.Write(PackageID);
            writer.Write((ushort)PackageType);
            tempStrings.Add(writer.Tell(), Description); // return to this later
            writer.Write((long)0);
            writer.Write(IsRequired);
            writer.Write(U11);
            writer.WriteNulls(0x3E);
            // we've hit the end of the data, and are now safe to write strings
            foreach (var tStr in tempStrings)
            {
                long strPos = writer.Tell();
                writer.Seek((int)(tStr.Key), SeekOrigin.Begin);
                writer.WriteOffset(strPos - basePos, basePos);
                writer.Seek((int)strPos, SeekOrigin.Begin);
                writer.WriteString(Description, StringFormat.NullTerminated);
                long postPos = writer.Tell();
                if (postPos - strPos < 32)
                {
                    writer.WriteNulls(32 - (int)(postPos - strPos));
                }
            }
            long dataEnd = writer.Tell();
            // next, dump the POF1
            writer.WritePOF1();
            // finish with the EOFC, which also finalizes the ACPK and POF1 in the process
            writer.WriteEOFC();
            long acpkEnd = writer.Tell();
            // DataSize
            writer.Seek((int)basePos - 12, SeekOrigin.Begin);
            writer.Write((int)(dataEnd - basePos));
            writer.Seek((int)basePos - 28, SeekOrigin.Begin);
            writer.Write((int)(acpkEnd - basePos));
            writer.Seek((int)acpkEnd, SeekOrigin.Begin);
        }
    }
}
