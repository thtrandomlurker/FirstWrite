using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirstLib.IO
{

    // Modified writer class to help with writing specifically for FirstRead
    public class XWriter : BinaryWriter
    {
        private List<long> mOffsetPositions { get; }
        private int mCurDepth = 0;
        public long Tell()
        {
            return BaseStream.Position;
        }
        public void WriteOffset(long value, long basePos)
        {
            mOffsetPositions.Add(Tell() - basePos);
            Write(value);
        }
        public void WriteString(string value, StringFormat format, int length = -1)
        {
            switch(format)
            {
                case StringFormat.NullTerminated:
                {
                    Write(value.ToArray());
                    Write((byte)0);
                    break;
                }
                case StringFormat.FixedLength:
                {
                    if (length < 0)
                        throw new ArgumentException("Invalid string length");
                    else
                    {
                        // this math can be useful for fixed length too
                        long pre = Tell();
                        Write(value.ToArray());
                        long post = Tell();
                        WriteNulls(length - (int)(post - pre));
                    }
                    break;
                }
                default:
                    throw new ArgumentException("Invalid string format", nameof(format));
            }
        }
        public void WriteNulls(int count)
        {
            for (int i = 0; i < count; i++)
                Write((Byte)0);
        }
        public void Align(int alignment)
        {
            int p = (int)Tell();
            int numToWrite = 0;
            if (p % alignment != 0)
                numToWrite = (alignment - (p % alignment));
            WriteNulls(numToWrite);
        }
        public void WriteHeader(char[] signature)
        {
            Write(signature);
            Write(0);
            Write(32);
            Write(0x10000000);
            Write(mCurDepth);
            Write(0);
            Write(0);
            Write(0);
            mCurDepth += 1;
        }
        // Call this after the data was written
        public void WritePOF1()
        {
            Write(new char[4] {'P', 'O', 'F', '1'});
            long pofContentsSizePos = Tell();
            Write(0);
            Write(32);
            Write(0x10000000);
            Write(mCurDepth);
            long pofDataSizePos = Tell();
            Write(0);
            Write(0);
            Write(0);
            // This all comes from MML so credit skyth, or korenkonder, i don't remember who figured this out
            var bytes = new List<byte>();

            long currentOffset = 0;

            foreach (long offset in mOffsetPositions.Distinct().OrderBy(x => x))
            {
                long distance = (offset - currentOffset) >> 3;

                if (distance > 0x3FFF)
                {
                    bytes.Add((byte)(0xC0 | (distance >> 24)));
                    bytes.Add((byte)(distance >> 16));
                    bytes.Add((byte)(distance >> 8));
                    bytes.Add((byte)(distance & 0xFF));
                }
                else if (distance > 0x3F)
                {
                    bytes.Add((byte)(0x80 | (distance >> 8)));
                    bytes.Add((byte)distance);
                }
                else
                {
                    bytes.Add((byte)(0x40 | distance));
                }

                currentOffset = offset;
            }
            long start = Tell();
            Write(4 + bytes.Count);

            foreach (byte val in bytes)
                Write(val);

            Align(8);
            // If we've written the POF1, we can clear it out
            mOffsetPositions.Clear();
            // just to be safe, let's align 16
            Align(16);
            long end = Tell();
            Seek((int)pofContentsSizePos, SeekOrigin.Begin);
            Write((int)(end - start));
            Seek((int)pofDataSizePos, SeekOrigin.Begin);
            Write((int)(end - start));
            Seek((int)end, SeekOrigin.Begin);
        }
        public void WriteEOFC()
        {
            Write(new char[4] { 'E', 'O', 'F', 'C' });
            Write(0);
            Write(32);
            Write(0x10000000);
            Write(mCurDepth);
            Write(0);
            Write(0);
            Write(0);
            mCurDepth -= 1;
        }
        public XWriter(Stream output) : base(output)
        {
            mOffsetPositions = new List<long>();
        }
        public XWriter(Stream output, Encoding encoding) : base(output, encoding)
        {
            mOffsetPositions = new List<long>();
        }
    }
}
