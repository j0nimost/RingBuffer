using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RingBuffer
{
    public class Publisher<T>
    {
        private RingBuffer<string> Buffer;

        public Publisher(RingBuffer<string> buffer)
        {
            Buffer = buffer;
        }

        public async Task Publish(string[] SportCars)
        {

            int i = 0;
            while (i < SportCars.Length)
            {
                if (Buffer.Write(SportCars[i]))
                {
                    Console.WriteLine($"Published: {SportCars[i]}");
                    await Task.Delay(700);

                }
                i++;
            }


            return;
        }
    }
}
