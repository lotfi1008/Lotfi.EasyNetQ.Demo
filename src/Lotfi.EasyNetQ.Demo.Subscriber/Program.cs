using EasyNetQ;
using Lotfi.EasyNetQ.Demo.Messages;
using System;

namespace Lotfi.EasyNetQ.Demo.Subscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var bus=RabbitHutch.CreateBus("host=localhost"))
            {
                bus.Subscribe<TextMessage>("test",HandleTextMessage);

                Console.WriteLine("Listening for messages. Hit <return> to quite.");
                Console.ReadLine();
            }
        }
        static void HandleTextMessage(TextMessage textMessage)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"Got message : {textMessage.Text}");
            Console.ResetColor();
        }
    }
}
