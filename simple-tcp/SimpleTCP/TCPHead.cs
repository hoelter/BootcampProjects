using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace SimpleTCP
{
    public class TCPHead : HeadAbstract, IPacket
    {
        private ushort usSourcePort; //16 bits
        private ushort usDestinationPort; //16bits
        private uint uiSequenceNumber; //32 bits
        private uint uiAcknowledgementNumber; //32bits
        private BitArray baDataOffset;// 4 bits
        private BitArray baReserved; //3 bits
        private BitArray baControlBits; //9? bits
        private ushort usWindow;// 16 bits
        private short sChecksum;//16 bits
        private ushort usUrgentPointer; //16 bits

        public uint SequenceNumber
        {
            get
            {
                return uiSequenceNumber;
            }

            set
            {
                uiSequenceNumber=value;
            }
        }

        // baOptions in abstract 0 default
        // baOptions in abstract 0 default
        // private BitArray data;

        public TCPHead()
        {
            usSourcePort = 0;
            usDestinationPort = 255;
            SequenceNumber = 0;
            uiAcknowledgementNumber = 0;
            baDataOffset = new BitArray(new bool[] {false, true, false, true }); //default 4 bit length set to decimal value of 5, length of tcp header
            baReserved = new BitArray(3, false);
            baControlBits = new BitArray(9);
            usWindow = 16384;
            sChecksum = 0;
            usUrgentPointer = 0;
            Options = null;
            baPadding = null;
        }

        private void CalculateDataOffset()
        {
            int headerWordLength = CalculateBinary().Length/4;
            string offsetInBinary = Convert.ToString(headerWordLength, 2);
            if (offsetInBinary.Length > 4) throw new ArgumentOutOfRangeException("Binary number cannot be represented with more than 4 bits", "offsetInBinary.Length");
            int binaryIndex = offsetInBinary.Length-1;
            for (int i = baDataOffset.Length-1; i >= 0; i--)
            {
                try
                {
                    baDataOffset[i] = Convert.ToBoolean((int)char.GetNumericValue(offsetInBinary[binaryIndex]));
                }
                catch
                {
                    baDataOffset[i] = false;
                }
                binaryIndex--;
            }
        }

        public byte[] OutputBinary()
        {
            CalculateDataOffset();
            byte[] binary = CalculateBinary();
            return binary;
        }

        protected override byte[] CalculateBinary()
        {
            List<byte[]> byteArrayList = new List<byte[]>();
            byteArrayList.Add(ToByteArray(usSourcePort));
            byteArrayList.Add(ToByteArray(usDestinationPort));
            byteArrayList.Add(ToByteArray(UiSequenceNumber));
            byteArrayList.Add(ToByteArray(uiAcknowledgementNumber));
            byteArrayList.Add(CombineDataoffsetReservedControlbits());
            byteArrayList.Add(ToByteArray(usWindow));
            byteArrayList.Add(ToByteArray(sChecksum));
            byteArrayList.Add(ToByteArray(usUrgentPointer));
            if (Options != null) byteArrayList.Add(CombineOptionsPadding());
            byte[] binary = CombineAll(byteArrayList);
            return binary;
        }

        private byte[] CombineDataoffsetReservedControlbits()
        {
            BitArray combined = new BitArray(baDataOffset.Cast<bool>().Concat(baReserved.Cast<bool>()).Concat(baControlBits.Cast<bool>()).ToArray());
            byte[] binary = new byte[(int)Math.Ceiling((double)combined.Length / 8)];
            combined.CopyTo(binary, 0);
            return binary;
        }
    }
}
