using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FirstLib.FirstRead;

namespace FirstLib.IO
{
    public enum XSeekOrigin
    {
        Begin,
        Base,
        Current,
        End
    }
    public class XReader : BinaryReader
    {
        private StringBuilder mStringBuilder;
        private Encoding mEncoding;
        private int mBasePos;
        public void Seek(int pos, XSeekOrigin origin)
        {
            if (origin == XSeekOrigin.Begin)
                BaseStream.Seek(pos, SeekOrigin.Begin);
            if (origin == XSeekOrigin.Base)
                BaseStream.Seek(pos + mBasePos, SeekOrigin.Begin);
            else if (origin == XSeekOrigin.Current)
                BaseStream.Seek(pos, SeekOrigin.Current);
            else if (origin == XSeekOrigin.End)
                BaseStream.Seek(pos, SeekOrigin.End);
        }
        public int Tell()
        {
            return (int)BaseStream.Position;
        }
        public char[] CheckNextSection()
        {
            char[] nextSectionSignature = ReadChars(4);
            Seek(-4, XSeekOrigin.Current);
            return nextSectionSignature;
        }
        public void SkipNextSection()
        {
            XHeader nextSectionHeader = new XHeader();
            nextSectionHeader.Read(this);
            // seek past the data
            Seek(nextSectionHeader.DataSize, XSeekOrigin.Current);
        }
        public void ReadOffset(Action action)
        {
            long offset = ReadInt64();
            if (offset == 0)
                return;
            int pre = Tell();
            Seek((int)offset, XSeekOrigin.Base);
            action();
            Seek(pre, XSeekOrigin.Begin);
        }
        public void ReadAtOffset(int offset, Action action)
        {
            if (offset == 0)
                return;
            int pre = Tell();
            Seek((int)offset, XSeekOrigin.Base);
            action();
            Seek(pre, XSeekOrigin.Begin);
        }
        public string ReadString(StringFormat format, int length = -1)
        {
            mStringBuilder.Clear();
            switch (format)
            {
                case StringFormat.NullTerminated:
                {
                    char b;
                    while ((b = ReadChar()) != 0)
                    {
                        mStringBuilder.Append(b);
                    }
                    break;
                }
                case StringFormat.FixedLength:
                {
                    if (length < 0)
                        throw new ArgumentException("Invalid length specified");

                    var bytes = ReadBytes(length);
                    
                    int index = Array.IndexOf(bytes, (byte)0);
                    return index == -1 ? mEncoding.GetString(bytes) : mEncoding.GetString(bytes, 0, index);
                }
                default:
                    throw new ArgumentException("Unknown string format", nameof(format));
            }
            return mStringBuilder.ToString();
        }
        public string ReadStringOffset(StringFormat format, int length = -1)
        {
            long offset = ReadInt64();
            int cur = Tell();
            Seek((int)offset, XSeekOrigin.Base);
            string rStr = ReadString(format, length);
            Seek(cur, XSeekOrigin.Begin);
            return rStr;
        }
        public string ReadStringAtOffset(int offset, StringFormat format, int length = -1)
        {
            int cur = Tell();
            Seek((int)offset, XSeekOrigin.Base);
            string rStr = ReadString(format, length);
            Seek(cur, XSeekOrigin.Begin);
            return rStr;
        }
        public void UpdateBasePosition()
        {
            mBasePos = Tell();
        }
        private void Init(Encoding encoding)
        {
            mStringBuilder = new StringBuilder();
            mEncoding = encoding;
        }
        public XReader(Stream input) : base(input)
        {
            Init(Encoding.UTF8);
        }
        public XReader(Stream input, Encoding encoding) : base(input)
        {
            Init(encoding);
        }
    }
}
