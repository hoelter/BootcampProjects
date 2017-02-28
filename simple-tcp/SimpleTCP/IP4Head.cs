using System;
using System.Collections;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTCP
{
    public class IP4Head : HeadAbstract, IPacket
    {
        private BitArray baVersion; //4 bits
        private BitArray baHeaderLength; // 4 bits
        //private byte byVersionAndHeaderLength;
        private byte byDifferentiatedServices;
        private ushort usTotalLength;
        private ushort usIdentification;
        private BitArray baFlags; //3 bits
        private BitArray baOffset; //13bits
        //private ushort usFlagsAndOffset;
        private byte byTTL;
        private byte byProtocol;
        private short sChecksum;
        private uint uiSourceIPAddress;
        private uint uiDestinationIPAddress;
        // baOptions in abstract 0 default
        // baOptions in abstract 0 default

        // private byte[] byIPData = new byte[4096];

        public ushort TotalLength
        {
            set
            {
                //total length of header and data
                // (ushort)IPAddress.HostToNetworkOrder((short)value);
                // ^ byte order conversion may be required
                usTotalLength=value;
            }
        }

        public string SourceIPAddress
        {
            get
            {
                string ipAddress = ConvertIPAddress(uiSourceIPAddress);
                return ipAddress;
            }

            set
            {
                uint ipAddress = ConvertIPAddress(value);
                uiSourceIPAddress = ipAddress;
            }
        }

        public string DestinationIPAddress
        {
            get
            {
                string ipAddress = ConvertIPAddress(uiDestinationIPAddress);
                return ipAddress;
            }

            set
            {
                uint ipAddress = ConvertIPAddress(value);
                uiDestinationIPAddress = ipAddress;
            }
        }

        public IP4Head(string SourceIPAddress = "192.168.1.1")
        {
            baVersion = new BitArray(new bool[] {false, true, false, false});
            baHeaderLength = new BitArray(4); //number of 32bit words in header
            byDifferentiatedServices = 0;
            usTotalLength = 0; //total packet size including header and data (set in third class) need to set in getter after the fact
            usIdentification = 0; // no one knows
            baFlags = new BitArray(3);
            baOffset = new BitArray(13); //specifies the offset of a particular fragment relative to the beginning of the original unfragmented ip datagram
            byTTL = 20; //time to live 20 seconds is standard (or 1?)
            byProtocol = 6;
            sChecksum = 0; //figure this shit out later
            this.SourceIPAddress = SourceIPAddress; 
        }

        public IP4Head(byte[] byBuffer, int nRecieved)
        {
            ParsePacketIPHead(byBuffer, nRecieved);
        }

        public byte[] OutputBinary()
        {
            byte[] binary = CalculateBinary();
            return binary;
        }

        protected override byte[] CalculateBinary()
        {
            List<byte[]> byteArrayList = new List<byte[]>();
            byteArrayList.Add(CombineVersionHeaderlength());
            byteArrayList.Add(ToByteArray(byDifferentiatedServices));
            byteArrayList.Add(ToByteArray(usTotalLength));
            byteArrayList.Add(ToByteArray(usIdentification));
            byteArrayList.Add(CombineFlagsOffset());
            byteArrayList.Add(ToByteArray(byTTL));
            byteArrayList.Add(ToByteArray(byProtocol));
            byteArrayList.Add(ToByteArray(sChecksum));
            byteArrayList.Add(ToByteArray(uiSourceIPAddress));
            byteArrayList.Add(ToByteArray(uiDestinationIPAddress));
            if (Options != null) byteArrayList.Add(CombineOptionsPadding());
            byte[] binary = CombineAll(byteArrayList);
            return binary;
        }

        private void ParsePacketIPHead(byte[] byBuffer, int nRecieved)
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream(byBuffer, 0, nRecieved);
                BinaryReader binaryReader = new BinaryReader(memoryStream);
                SeparateVersionHeaderlength(binaryReader.ReadByte());
                byDifferentiatedServices = binaryReader.ReadByte();
                usTotalLength = (ushort)IPAddress.NetworkToHostOrder(binaryReader.ReadInt16());
                usIdentification = (ushort)IPAddress.NetworkToHostOrder(binaryReader.ReadInt16());
                SeparateFlagsOffset((ushort)IPAddress.NetworkToHostOrder(binaryReader.ReadInt16()));
                byTTL = binaryReader.ReadByte();
                byProtocol = binaryReader.ReadByte();
                sChecksum = IPAddress.NetworkToHostOrder(binaryReader.ReadInt16());
                uiSourceIPAddress = (uint)(binaryReader.ReadInt32());
                uiDestinationIPAddress = (uint)(binaryReader.ReadInt32());
            }
            catch (Exception ex)
            {
                Console.WriteLine("MJSniff error");
            }
        }

        private byte[] CombineFlagsOffset()
        {
            BitArray combined = new BitArray(baFlags.Cast<bool>().Concat(baOffset.Cast<bool>()).ToArray());
            byte[] binary = new byte[(int)Math.Ceiling((double)combined.Length / 8)];
            combined.CopyTo(binary, 0);
            if (binary.Length > 2) throw new ArgumentOutOfRangeException("Byte array should only be holding one byte", "binary.Length");
            return binary;
        }

        private byte[] CombineVersionHeaderlength()
        {
            BitArray combined = new BitArray(baVersion.Cast<bool>().Concat(baHeaderLength.Cast<bool>()).ToArray());
            byte[] binary = new byte[(int)Math.Ceiling((double)combined.Length / 8)];
            combined.CopyTo(binary, 0);
            if (binary.Length > 1) throw new ArgumentOutOfRangeException("Byte array should only be holding one byte", "binary.Length");
            return binary;
        }

        private uint ConvertIPAddress(string ipAddress)
        {
            uint intAddress = BitConverter.ToUInt32(IPAddress.Parse(ipAddress).GetAddressBytes(), 0);
            return intAddress;
        }

        private string ConvertIPAddress(uint ipAddress)
        {
            string stringAddress = new IPAddress(BitConverter.GetBytes( uiSourceIPAddress)).ToString();
            return stringAddress;
        }

        private void SeparateVersionHeaderlength(byte input)
        {
            BitArray both = new BitArray(input);
            baVersion = new BitArray(both.Length/2);
            baHeaderLength = new BitArray(both.Length/2);
            for (int i = 0; i < both.Length; i++)
            {
                if (i<4) baVersion[i] = both[i];
                else baHeaderLength[i-4] = both[i];
            }
        }

        private void SeparateFlagsOffset(ushort input)
        {
            string flagsAndOffsetInBinary = Convert.ToString(input, 2);

            baFlags = new BitArray(3);
            baOffset = new BitArray(13);
            for (int i = 0; i < flagsAndOffsetInBinary.Length; i++)
            {
                if (i<4) baFlags[i] = Convert.ToBoolean((int)char.GetNumericValue(flagsAndOffsetInBinary[i]));
                else baOffset[i-4] = Convert.ToBoolean((int)char.GetNumericValue(flagsAndOffsetInBinary[i]));
            }
        }

      


        //private class IPHeadRebuilder : IPHead
        //{
        //    public IPHeadRebuilder(byte[] byBuffer, int nRecieved)
        //    {
        //        parsePacketIPHead(byBuffer, nRecieved);
        //    }

        //    private void SeparateVersionHeaderlength(byte input)
        //    {
        //        BitArray both = new BitArray(input);
        //        baVersion = new BitArray(both.Length/2);
        //        baHeaderLength = new BitArray(both.Length/2);
        //        for (int i = 0; i < both.Length; i++)
        //        {
        //            if (i<4) baVersion[i] = both[i];
        //            else baHeaderLength[i-4] = both[i];
        //        }
        //    }

        //    private void SeparateFlagsOffset(ushort input)
        //    {
        //        string flagsAndOffsetInBinary = Convert.ToString(input, 2);

        //        baFlags = new BitArray(3);
        //        baOffset = new BitArray(13);
        //        for (int i = 0; i < flagsAndOffsetInBinary.Length; i++)
        //        {
        //            if (i<4) baFlags[i] = Convert.ToBoolean((int)char.GetNumericValue(flagsAndOffsetInBinary[i]));
        //            else baOffset[i-4] = Convert.ToBoolean((int)char.GetNumericValue(flagsAndOffsetInBinary[i]));
        //        }
        //    }

        //    private void parsePacketIPHead(byte[] byBuffer, int nRecieved)
        //    {
        //        try
        //        {
        //            MemoryStream memoryStream = new MemoryStream(byBuffer, 0, nRecieved);
        //            BinaryReader binaryReader = new BinaryReader(memoryStream);
        //            SeparateVersionHeaderlength(binaryReader.ReadByte());
        //            byDifferentiatedServices = binaryReader.ReadByte();
        //            usTotalLength = (ushort)IPAddress.NetworkToHostOrder(binaryReader.ReadInt16());
        //            usIdentification = (ushort)IPAddress.NetworkToHostOrder(binaryReader.ReadInt16());
        //            SeparateFlagsOffset((ushort)IPAddress.NetworkToHostOrder(binaryReader.ReadInt16()));
        //            byTTL = binaryReader.ReadByte();
        //            byProtocol = binaryReader.ReadByte();
        //            sChecksum = IPAddress.NetworkToHostOrder(binaryReader.ReadInt16());
        //            uiSourceIPAddress = (uint)(binaryReader.ReadInt32());
        //            uiDestinationIPAddress = (uint)(binaryReader.ReadInt32());
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("MJSniff error");
        //        }
        //    }
        //}
    }
}
