using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class SupportRequest
    {
        private int _id;
        private string _userName;
        private RequestStatus _status;
        private SupportSpecialist _specialist;
        private List<Message> _messageList;

        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }

        public string UserName
        {
            set { _userName = value; }
            get { return _userName; }
        }

        public RequestStatus Status
        {
            set { _status = value; }
            get { return _status; }
        }

        public SupportSpecialist Specialist
        {
            set { _specialist = value; }
            get { return _specialist; }
        }

        public List<Message> MessageList
        {
            set { _messageList = value; }
            get { return _messageList; }
        }

        public SupportRequest(int id, string userName, RequestStatus status, SupportSpecialist specialist)
        {
            _id = id;
            _userName = userName;
            _status = status;
            _specialist = specialist;
            _messageList = new List<Message>();
        }

        public override string ToString()
        {
            return "ID запису: " + ID + ". Користувач: " + UserName + ". Оператор: " + Specialist + ". Статус запису: " + Status + "\nIсторiя повiдомлень: \n" + GetMessageHistory();
        }

        public void SendMessage(string sender, string recepient, string text)
        {
            _messageList.Add(new Message(sender, recepient, text));
        }

        public string GetMessageHistory()
        {
            if (_messageList.Capacity == 0) return "Iсторiя порожня";
            else
            {
                string res = "";
                foreach (Message item in _messageList)
                {
                    res += item + "\n";
                }
                return res;
            }
        }


    }
}
