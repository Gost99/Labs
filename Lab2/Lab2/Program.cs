using System;

namespace Lab2
{
    class Program
    {
        static string s;
        static char[] sym = { 'г', 'о', 'д', 'х', 'в' };
        static void Main(string[] args)
        {
            try
            {
                s = Console.ReadLine();
                if (!s.Contains("год") && !s.Contains("хв")) throw new Exception("Некоректне введення!");
                if (s.Contains("год")) ConvertMinutes(s, "год");
                else ConvertMinutes(s);
            }
            catch (Exception e)
            {
                Console.WriteLine("Помилка: " + e.Message);
            }

            Console.ReadKey();
        }

        static void ConvertMinutes(string input, string str)
        {
            string[] words = input.Split(new char[] { 'д' });
            int hour, min;
            if (s.Contains("хв"))
            {
                hour = Convert.ToInt32(words[0].Trim(sym));
                if (hour < 0) throw new Exception("Неправильно введено години!");
                min = Convert.ToInt32(words[1].Trim(sym));
                if (min > 60 || min < 0) throw new Exception("Неправильно введено хвилини!");
            }
            else 
            {
                min = 0;
                hour = Convert.ToInt32(words[0].Trim(sym));
                if (hour < 0) throw new Exception("Неправильно введено години!");
            }
            int num = min;

            while (hour > 0)
            {
                num += 60;
                hour--;
            }
            Console.WriteLine("{0} хв", num);
        }

        static void ConvertMinutes(string input)
        {
            int min = Convert.ToInt32(input.Trim(sym));
            if (min < 0) throw new Exception("Неправильно введено хвилини!");

            int hour = 0;

            while (min >= 60)
            {
                min -= 60;
                hour++;
            }
            Console.WriteLine("{0} год {1} хв ",hour,min);
        }
    }
}
