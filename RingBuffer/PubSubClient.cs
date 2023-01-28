using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RingBuffer
{
    public class PubSubClient
    {


        public async Task Run()
        {
            RingBuffer<string> buffer = new RingBuffer<string>(5);
            var publisher = new Publisher(buffer);
            var subscriber = new Subscriber(buffer);

            Task[] tasks = new Task[2]
            {
                publisher.Publish(),
                subscriber.Subscribe()
            };


            Task.WaitAll(tasks);
            return;
        }

    }
}
