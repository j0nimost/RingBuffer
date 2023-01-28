using RingBuffer;
using System;
using System.Threading;

Console.WriteLine("Sample Ring Buffer PubSub");
Console.WriteLine("\tCtrl + C to Stop");
PubSubClient pubSubClient = new PubSubClient();
await pubSubClient.Run();
