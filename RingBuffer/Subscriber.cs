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

        public async Task Subscribe()
        {

            while(!Buffer.IsEmpty())
            {
                // try reading from buffer
                string car = Buffer.Read();
                if (!string.IsNullOrEmpty(car))
                {
                    Console.WriteLine($"Subscribed To : {car}");
                }
                await Task.Delay(1000);

            }

            return;

        }
    }
}
