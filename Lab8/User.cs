using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class User
    {
        public string Username { set; get; }
        public string Key { set; get; }

        private bool activateStatus = false;

        public bool ActivateStatus
        {
            get { return activateStatus; }
        }

        readonly KeysRandom kR = new KeysRandom();

        public User(string usName)
        {
            this.Username = usName;
            this.Key = kR.GetKey();
            Console.WriteLine("Ваш ключ: " + Key);
        }

        public bool Activate()
        {
            Console.WriteLine("Введiть ваш ключ:");
            string keyToCheck = Console.ReadLine();

            if (this.Key == keyToCheck)
            {
                Console.WriteLine("Ваш акаунт активовано");
                activateStatus = true;
                return true;
            }
            else
            {
                Console.WriteLine("Ключ введено не правильно");
                return false;
            }
        }

        public bool CheckActivate()
        {
            if (this.ActivateStatus == true)
            {
                Console.WriteLine("Даного користувача активовано");
                return true;
            }
            else
            {
                Console.WriteLine("Даного користувача не активовано");
                return false;
            }
        }
    }
}
