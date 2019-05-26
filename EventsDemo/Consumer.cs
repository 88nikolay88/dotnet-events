using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    class Consumer
    {
        public void ProcessNewMessage(string _text) {
            Console.WriteLine("Got new message: " + _text + " " + GetHashCode());
        }
    }
}
