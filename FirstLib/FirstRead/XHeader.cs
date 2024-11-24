using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FirstLib.IO;

namespace FirstLib.FirstRead
{
    public class XHeader
    {
        public char[] Signature;
        public int ContentsSize;
        public int HeaderSize;
        public int Flags;
        public int SectionDepth;
        public int DataSize;
        public int U18;
        public int U1C;

        public void Read(XReader reader)
        {
            Signature = reader.ReadChars(4);
            ContentsSize = reader.ReadInt32();
            HeaderSize = reader.ReadInt32();
            Flags = reader.ReadInt32();
            SectionDepth = reader.ReadInt32();
            DataSize = reader.ReadInt32();
            U18 = reader.ReadInt32();
            U1C = reader.ReadInt32();
            // nearly forgot this
            reader.Seek(HeaderSize - 32, XSeekOrigin.Current);
        }
    }
}
