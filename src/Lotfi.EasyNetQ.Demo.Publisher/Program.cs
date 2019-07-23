using EasyNetQ;
using Lotfi.EasyNetQ.Demo.Messages;
using System;

namespace Lotfi.EasyNetQ.Demo.Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                var input = "";
                Console.WriteLine("Enter a message. 'Quite' to quite.");
                while ((input=Console.ReadLine())!="Quite")
                {
                    bus.Publish(new TextMessage
                    {
                        Text = input
                    });
                }
            }
        }
    }
}
