using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTCP;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            PacketTCP test = new PacketTCP();
            long[] temp = new long[2000];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = 100;
            }
            var packets = test.CreatePackets<long[]>(temp);
            Console.WriteLine("End Test");
            Console.WriteLine(packets.Count);
            // tests out properly as 12 now, redid calc12? check similar header function
        }
    }
}