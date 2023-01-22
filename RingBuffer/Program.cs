using RingBuffer;
using System;
using System.Threading;

Console.WriteLine("Sample Ring Buffer PubSub");
PubSubClient pubSubClient = new PubSubClient();
await pubSubClient.Run();

