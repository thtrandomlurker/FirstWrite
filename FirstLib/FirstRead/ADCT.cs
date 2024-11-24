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
    public class ADCT
    {
        public XHeader Header;
        public ACPK AddonContentPackage;
        public List<ACCT> AddonContentContainers;

        public void Read(XReader reader)
        {
            Header = new XHeader();
            Header.Read(reader);
            if (Header.Signature[0] != 'A' && Header.Signature[1] != 'D' && Header.Signature[2] != 'C' && Header.Signature[3] != 'T')
                throw new InvalidDataException("Invalid file");
            AddonContentPackage = new ACPK();
            AddonContentPackage.Read(reader);
            // grab the ACCTs which are a part of the ADCT, not the ACPK
            while (true)
            {
                char[] check = reader.CheckNextSection();
                if (check[0] == 'A' && check[1] == 'C' && check[2] == 'C' && check[3] == 'T')
                {
                    ACCT AddonContentContainer = new ACCT();
                    AddonContentContainer.Read(reader);
                    AddonContentContainers.Add(AddonContentContainer);
                }
                else if (check[0] == 'E' && check[1] == 'N' && check[2] == 'R' && check[3] == 'S')  // probably enough to make a guess
                {
                    reader.SkipNextSection();
                }
                else if (check[0] == 'P' && check[1] == 'O' && check[2] == 'F' && check[3] == '1')  // probably enough to make a guess
                {
                    reader.SkipNextSection();
                }
                else if (check[0] == 'E' && check[1] == 'O' && check[2] == 'F' && check[3] == 'C')
                {
                    reader.SkipNextSection();  // the ADCT eofc that is
                    break;
                }
            }
            // End of Read func... because nothing comes after the ACCTs
        }
        public void Write(XWriter writer)
        {
            writer.WriteHeader(new char[4] {'A', 'D', 'C', 'T'});
            AddonContentPackage.Write(writer);
            foreach (var container in AddonContentContainers)
            {
                container.Write(writer);
            }
            writer.WriteEOFC();
            long contentsEnd = writer.Tell();
            writer.Seek(4, SeekOrigin.Begin);
            writer.Write((int)(contentsEnd - 32));
            writer.Seek((int)contentsEnd, SeekOrigin.Begin);
            writer.WriteEOFC();
        }

        public ADCT()
        {
            AddonContentContainers = new List<ACCT>();
            AddonContentPackage = new ACPK() { U00 = 0, PackageID = 0, PackageType = ACPKType.Base, Description = "", U11 = 0, IsRequired = 0 };
        }
    }
}
