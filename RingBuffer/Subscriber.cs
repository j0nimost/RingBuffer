using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RingBuffer
{
    public class Subscriber
    {
        private RingBuffer<string> Buffer;
        public Subscriber(RingBuffer<string> buffer)
        {
            Buffer = buffer;
        }

        public Task Subscribe()
        {
            int i = 0;
            while(true)
            {
                // try reading from buffer

                string car = Buffer.Read();
                if (!string.IsNullOrEmpty(car))
                {
                    i++;
                    Console.WriteLine($"[-] Subscribed To : {car}\t itemNo: {i}");
                    
                }
            }
        }
    }
}
