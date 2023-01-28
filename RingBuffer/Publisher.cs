using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RingBuffer
{
    public class Publisher
    {
        private RingBuffer<string> Buffer;
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
        public Publisher(RingBuffer<string> buffer)
        {
            Buffer = buffer;
        }

        public async Task Publish()
        {
            int i = 0;
            while (i < SportCars.Length)
            {
                while (Buffer.IsFull())
                    await Task.Delay(100);

                if (Buffer.Write(SportCars[i]))
                {
                    Console.WriteLine($"Published: {SportCars[i]}");
                    i++;
                }
            }

            Console.WriteLine($"Published {i} items");
        }
    }
}
