using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class UserSystem
    {
        private List<User> userList;

        public UserSystem()
        {
            userList = new List<User>();
        }

        public void AddUser(string usName)
        {
            if (usName == "")
                usName = "User1";
            userList.Add(new User(usName));
        }

        public bool Activate(string usName)
        {
            if (userList.Exists(x => x.Username == usName))
            {
                var curUser = userList.Find(x => x.Username == usName);
                return curUser.Activate();
            }
            else
            {
                Console.WriteLine("Даного користувача не iснує");
                return false;
            }
        }

        public bool CheckActivate(string usName)
        {
            if (userList.Exists(x => x.Username == usName))
            {
                var curUser = userList.Find(x => x.Username == usName);
                return curUser.CheckActivate();

            }
            else
            {
                Console.WriteLine("Даного користувача не iснує");
                return false;
            }
        }


    }
}
