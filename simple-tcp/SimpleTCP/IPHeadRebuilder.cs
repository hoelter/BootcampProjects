using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace SimpleTCP
{
    public class IPHeadRebuilder
    {
        private byte byVersionAndHeaderLength;
        private byte byDifferentiatedServices;
        private ushort usTotalLength;
        private ushort usIdentification;
        private ushort usFlagsAndOffset;
        private byte byTTL;
        private byte byProtocol;
        private short sChecksum;
        private uint uiSourceIPAddress;
        private uint uiDestinationIPAddress;

        private byte byHeaderLength;
        private byte[] byIPData = new byte[4096];

         public IPHeadRebuilder(byte[] byBuffer, int nRecieved)
        {
            parsePacketIPHead(byBuffer, nRecieved);
        }

        //private void SeparateVersionAndHeaderLength(byte input)
        //{
        //    BitArray both = new BitArray(byVersionAndHeaderLength);
        //    var t = both[0];
        //    baVersion = new BitArray(both.Length/2);
        //    baHeaderLength = new BitArray(both.Length/2);
        //    for (int i = 0; i < byVersionAndHeaderLength; i++)
        //    {
        //        if (i<4) baVersion[i] = both[i];
        //        else baHeaderLength[i-4] = both[i];
        //    }
        //}
        private void parsePacketIPHead(byte[] byBuffer, int nRecieved)
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream(byBuffer, 0, nRecieved);
                BinaryReader binaryReader = new BinaryReader(memoryStream);
                //The first eight bits of the IP header contain the version and
                //header length so we read them
                byVersionAndHeaderLength = binaryReader.ReadByte();
                byDifferentiatedServices = binaryReader.ReadByte();
                usTotalLength = (ushort)IPAddress.NetworkToHostOrder(binaryReader.ReadInt16());
                //Next sixteen have the identification bytes
                usIdentification = (ushort)IPAddress.NetworkToHostOrder(binaryReader.ReadInt16());
                //Next sixteen bits contain the flags and fragmentation offset
                usFlagsAndOffset = (ushort)IPAddress.NetworkToHostOrder(binaryReader.ReadInt16());
                //Next eight bits have the TTL value
                byTTL = binaryReader.ReadByte();
                //Next eight represent the protocol encapsulated in the datagram
                byProtocol = binaryReader.ReadByte();
                //Next sixteen bits contain the checksum of the header
                sChecksum = IPAddress.NetworkToHostOrder(binaryReader.ReadInt16());
                //Next thirty two bits have the source IP address
                uiSourceIPAddress = (uint)(binaryReader.ReadInt32());
                //Next thirty two hold the destination IP address
                uiDestinationIPAddress = (uint)(binaryReader.ReadInt32());
                //Now we calculate the header length
                byHeaderLength = byVersionAndHeaderLength;
                //The last four bits of the version and header length field contain the
                //header length, we perform some simple binary arithmetic operations to
                //extract them
                byHeaderLength <<= 4;
                byHeaderLength >>= 4;
                //Multiply by four to get the exact header length
                byHeaderLength *= 4;
                //Copy the data carried by the datagram into another array so that
                //according to the protocol being carried in the IP datagram
                Array.Copy(byBuffer, 
                           byHeaderLength, //start copying from the end of the header
                           byIPData, 0, usTotalLength - byHeaderLength);
            }
            catch (Exception ex)
            {
                Console.WriteLine("MJSniff error");
            }
        }
    }
}
