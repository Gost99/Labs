using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Message
    {
        private string _sender;
        private string _recepient;
        private string _messageText;

        public string Sender
        {
            set { _sender = value; }
            get { return _sender; }
        }

        public string Recepient
        {
            set { _recepient = value; }
            get { return _recepient; }
        }
        public string MessageText
        {
            set { _messageText = value; }
            get { return _messageText; }
        }

        public Message(string sender, string recepient, string messageText)
        {
            _sender = sender;
            _recepient = recepient;
            _messageText = messageText;
        }

        public override string ToString()
        {
            return "Вiдправник: " + Sender + ". Отримувач: оператор " + Recepient + ". Текст: " + MessageText;
        }

    }
}
