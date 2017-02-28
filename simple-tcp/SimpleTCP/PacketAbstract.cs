using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTCP
{
    abstract public class PacketAbstract
    {
        protected byte[] CombineAll(List<byte[]> byteArrayList)
        {
            int count = 0;
            foreach (byte[] byteArray in byteArrayList)
            {
                count = count + byteArray.Length;
            }
            byte[] allCombined = new byte[count];
            int offset = 0;
            foreach (byte[] byteArray in byteArrayList)
            {
                Buffer.BlockCopy(byteArray, 0, allCombined, offset, byteArray.Length);
                offset += byteArray.Length;
            }
            return allCombined;
        }
    }
}
