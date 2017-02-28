using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleTCP
{
    public class PacketBody<T> : IPacket
    {
        public T Data { get; private set; }
        private BinaryFormatter bf = new BinaryFormatter();
        private byte[] byteData;

        public PacketBody(T input)
        {
            Data = input;
            byteData = ConvertToByteArray(input);
        }

        public PacketBody(byte[] input)
        {
            DecodeByteArray(input);
            byteData = input;
        }

        public byte[] OutputBinary()
        {
            return byteData;
        }

        private byte[] ConvertToByteArray(T input)
        {
            if (input == null)
                return null;
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, input);
                return ms.ToArray();
            }
        }

        private void DecodeByteArray(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(bytes, 0, bytes.Length);
                ms.Seek(0, SeekOrigin.Begin);
                Data = (T)bf.Deserialize(ms);
            }
        }

    }
}
