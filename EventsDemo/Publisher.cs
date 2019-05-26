using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    class Publisher
    {

        private static Publisher instnace;

        public delegate void NewMessage(string _text);
        public event NewMessage NewMessageEvent;

        private Publisher(){}

        public static Publisher GetInstance() {

            /* if (instnace == null)
            {
                instnace = new Publisher();
            }
            return instnace; */
            return instnace ?? (instnace = new Publisher());
        }

        public void Fire(string _text)
        {
            if (NewMessageEvent != null)
            {
                NewMessageEvent.Invoke(_text);
            }
        }

        public void AddSubscriber(NewMessage _newMessage) {
            NewMessageEvent += _newMessage;
        }

        public void RemoveSubscriber(NewMessage _newMessage)
        {
            if (NewMessageEvent != null)
            {
                NewMessageEvent -= _newMessage;
            }
        }
    }
}
