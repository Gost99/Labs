using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static int input;                  // число яке вводимо
        static int temp;                   // індекс елемента в масиві
        static int index = 0;              // кількість розрядів
        static int[] buffer = new int[7];  // масив в якому кожна цифра є окремим елементом

        static string[] ones = { "" , "один ", "два ", "три ", "чотири ", "п'ять ", "шiсть ", "сiм ", "вiсiм ", "дев'ять " };

        static string[] teens = { "десять ", "одинадцять ", "дванадцять ", "тринадцять ", "чотирнадцять ", "п'ятнадцять ", "шiстнадцять ", "сiмнадцять ", "вiсiмнадцять ", "дев'ятнадцять " };

        static string[] tens = { "","","двадцять ", "тридцять ", "сорок ", "п'ятдесят ", "шiстдесят ", "сiмдесят ", "вiсiмдесят ", "дев'яносто " };

        static string[] hundr = { "","сто ", "двiстi ", "триста ", "чотириста ", "п'ятсот ", "шiстсот ", "сiмсот ", "вiсiмсот ", "дев'ятсот " };

        static string[] ones_thous = { "","одна тисяча ", "двi тисячi ", "три тисячi ", "чотири тисячi ", "п'ять тисяч ", "шiсть тисяч ", "сiм тисяч ", "вiсiм тисяч ", "дев'ять тисяч " };

        static string stroka;               //вихідний рядок
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введiть число: ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input >= 0 && input <= 1000000) break;    //перевірка на належність числа умові
                Console.WriteLine("Введiть iнше число!");
                Console.ReadKey();
                Console.Clear();
            } while (true);
            if (input == 1000000) Console.WriteLine("{0} = мiльйон",input);
            else if (input == 0) Console.WriteLine("{0} = нуль",input);
            else
            {
                CreateIndex(input);     // поділ числа на розряди та його занесення до масиву розрядів
                CreateWords();
            }
            Console.ReadLine();
        }
        private static void CreateWords()
        {
            for (temp = index - 1; temp >= 0; temp--)
            {
                switch (temp)
                {
                    case 5: stroka += hundr[buffer[temp]];
                        break;
                    case 4: if (buffer[4] == 1) stroka += teens[buffer[temp-1]];
                        else stroka += tens[buffer[temp]];
                        if (buffer[3] == 0 || buffer[4]==1) stroka += "тисяч ";
                        break;
                    case 3: if (buffer[3] != 0 && buffer[4] != 1) stroka += ones_thous[buffer[temp]];
                        break;
                    case 2: stroka += hundr[buffer[temp]];
                        break;
                    case 1: if (buffer[1] == 1) stroka += teens[buffer[temp-1]];
                        else stroka += tens[buffer[temp]];
                        break;
                    case 0: if (buffer[1] != 1) stroka += ones[buffer[temp]];
                        break;
                }
            }
            Console.WriteLine("{0} = "+stroka,input);
        }
        static void CreateIndex(int number){
         do
                {
                    buffer[index] = number % 10;               
                    number /= 10;                              
                    index++;
                } while (number != 0);
        }
    }
}


