using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class KeysRandom
    {
        private static string AppendStr(int length, string str, char[] newKey)
        {
            string newKeyStr = "";
            int k = 0;
            for (int i = 0; i < length; i++)
            {
                for
                (k = i; k < 4 + i; k++)
                {
                    newKeyStr += newKey[k];
                }
                if (k == length)
                    break;

                else
                {
                    i = (k) - 1;
                    newKeyStr += str;
                }
            }
            return newKeyStr;
        }

        public string GetKey()
        {
            Guid newguid = Guid.NewGuid();
            string randomStr = newguid.ToString("N");
            string tracStr = randomStr.Substring(0,16);
            tracStr = tracStr.ToUpper();
            char[] newKey = tracStr.ToCharArray();

            string newSerialNumber = AppendStr(16, "-", newKey);
            return newSerialNumber;
        }


    }
}
