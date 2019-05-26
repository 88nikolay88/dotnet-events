using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    class Subscriber
    {
        static void Main(string[] args)
        {
            //The wrong way!
            // Publisher publisher = new Publisher();

            Publisher publisher = Publisher.GetInstance();

            Consumer consumer1 = new Consumer();
            Consumer consumer2 = new Consumer();

            publisher.AddSubscriber(consumer1.ProcessNewMessage);
            publisher.AddSubscriber(consumer2.ProcessNewMessage);

            publisher.Fire("Hello World!");

            // Test
        }
    }
}
