using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTCP
{
    public class PacketTCP : PacketAbstract
    {
        IP4Head ipHeader;
        TCPHead tcpHeader;
        public PacketTCP()
        {
            IP4Head ipHeader = new IP4Head();
            TCPHead tcpHeader = new TCPHead();
            PacketBody<string> body = new PacketBody<string>("Hello World");
        }

        public List<byte[]> CreatePackets<T>(T data)
        {
            ipHeader = new IP4Head();
            tcpHeader = new TCPHead();
            PacketBody<T> body = new PacketBody<T>(data);
            byte[] allPayload = body.OutputBinary();
            Console.WriteLine(string.Format("allPayload Length: {0}", allPayload.Length));
            byte[][] splitPayload = SplitPayload(allPayload);

            List<byte[]> allPackets = new List<byte[]>();
           
            foreach (byte[] partPayload in splitPayload)
            {
                List<byte[]> singlePacket = new List<byte[]>();
                singlePacket.Add(ipHeader.OutputBinary());
                singlePacket.Add(tcpHeader.OutputBinary());
                tcpHeader.SequenceNumber++;
                singlePacket.Add(partPayload);
                byte[] completePacket = CombineAll(singlePacket);
                ipHeader.TotalLength = (ushort)completePacket.Length;
                singlePacket[0] = ipHeader.OutputBinary();
                completePacket = CombineAll(singlePacket);
                allPackets.Add(completePacket);

            }
            return allPackets;
        }

        private byte[][] SplitPayload(byte[] allPayload)
        {
            int packetPayloadSize = 1400;
            int allPayloadsSize = CalcAmountPackets(allPayload.Length, packetPayloadSize);
            byte[][] allPacketPayloads = new byte[allPayloadsSize][];
            if (allPayload.Length > packetPayloadSize)
            {
                int srcOffset = 0;
                byte[] packetPayload;
                for (int i = 0; i < allPayloadsSize; i++)
                {
                    if (i < allPayloadsSize-1)
                    {
                        packetPayload = new byte[packetPayloadSize];
                    }
                    else
                    {
                        packetPayload = new byte[allPayload.Length-srcOffset];
                    }
                    Buffer.BlockCopy(allPayload, srcOffset, packetPayload, 0, packetPayload.Length);
                    srcOffset += packetPayloadSize;
                    allPacketPayloads[i] = packetPayload;
                }
            }
            else allPacketPayloads[0] = allPayload;
            return allPacketPayloads;
        }

        private int CalcAmountPackets(int allPayloadSize, int packetPayloadSize)
        {
            int amountPackets = 1;
            int tempSize = 0;
            while (tempSize < allPayloadSize)
            {
                amountPackets++;
                tempSize = packetPayloadSize * amountPackets;
            }
            return amountPackets;
        }
    }
}
