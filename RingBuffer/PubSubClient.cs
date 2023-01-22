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
        private string[] SportCars = new string[]
        {
            "Alfa Romeo 4C",
            "Alpine A108",
            "Ariel Atom",
            "Arrinera Hussarya",
            "Ascari A10",
            "Aston Martin Vantage",
            "Audi TT",
            "Bentley Continental GT",
            "Buick Reatta",
            "Bugatti EB110",
            "BMW Z8",
            "Caparo T1",
            "Caterham 21",
            "Chevrolet Camaro",
            "Dodge Challenger",
            "Dodge Viper",
            "Ferrari 458 Italia",
            "Fiat X19",
            "Ford Mustang",
            "Honda Integra",
            "Honda NSX",
            "Hyundai Genesis Coupe",
            "Hyundai Tiburon",
            "IFR Aspid",
            "Infiniti Emerg E",
            "Isuzu 117 Coupe",
            "Jaguar F-Type",
            "Lamborghini Murcielago",
            "Lexus LFA",
            "Lotus Elise",
            "Marussia B1",
            "Mazda RX 8",
            "Mastretta MXT",
            "McLaren 12C",
            "Nissan 240SX",
            "Opel Tigra",
            "Pontiac GTO",
            "Porsche 997",
            "Renault Wind",
            "Saturn Sky",
            "Toyota 86"
        };

        public async Task Run()
        {
            RingBuffer<string> buffer = new RingBuffer<string>(SportCars.Length);
            var publisher = new Publisher<string>(buffer);
            var subscriber = new Subscriber(buffer);

            Task[] tasks = new Task[2]
            {
                publisher.Publish(SportCars),
                subscriber.Subscribe()
            };

            await Task.WhenAll(tasks);


            return;
        }

    }
}
