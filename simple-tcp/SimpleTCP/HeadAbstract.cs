using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTCP
{
    abstract public class HeadAbstract : PacketAbstract
    {
        protected BitArray baOptions; // 0 default
        protected BitArray baPadding; // 0 default
        protected abstract byte[] CalculateBinary();

        public BitArray Options
        {
            protected get
            {
                return baOptions;
            }

            set
            {
                baOptions=value;
                if (value != null) AssignPadding();
            }
        }
       
        protected int Check32Multiple(int length)
        {
            int baseMultiple = 32;
            int multiplier = 2;
            int finalValue = 0;
            while (length > finalValue)
            {
                finalValue = baseMultiple * multiplier;
                multiplier += 1;
            }
            int difference = finalValue - length;
            return difference;
        }

        protected void AssignPadding()
        {
            int optionsLength = Options.Length;
            if (optionsLength % 32 != 0)
            {
                int paddingLength = Check32Multiple(optionsLength);
                this.baPadding = new BitArray(paddingLength, false);
            }
            else baPadding = null;
        }

        protected byte[] CombineOptionsPadding()
        {
            byte[] binary;
            if (baPadding != null)
            {
                BitArray combined = new BitArray(Options.Cast<bool>().Concat(baPadding.Cast<bool>()).ToArray());
                binary = new byte[(int)Math.Ceiling((double)combined.Length / 8)];
                combined.CopyTo(binary, 0);
            }
            else
            {
                binary = new byte[(int)Math.Ceiling((double)Options.Length / 8)];
            }
            return binary;
        }

        protected byte[] ToByteArray(ushort input)
        {
            var bytes = BitConverter.GetBytes(input);
            return bytes;
        }

        protected byte[] ToByteArray(uint input)
        {
            var bytes = BitConverter.GetBytes(input);
            return bytes;
        }

        protected byte[] ToByteArray(short input)
        {
            var bytes = BitConverter.GetBytes(input);
            return bytes;
        }

        protected byte[] ToByteArray(byte input)
        {
            byte[] output = new byte[] { input };
            return output;
        }
    }
}
