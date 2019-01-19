using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо список операторів. 
            var rend = new KeysRandom();
            var saveSystem = new UserSystem();
            var specList = CreateList();
            SupportRequest req1;

            Console.WriteLine("Доброго дня! Вас вiтає служба пiдтримки.");
            Console.WriteLine("Введiть своє iм'я: ");
            string curName = Console.ReadLine();
            saveSystem.AddUser(curName);

            Console.WriteLine("Введiть iмя користувача");
            if (saveSystem.Activate(Console.ReadLine()))
            {

                req1 = new SupportRequest(new Random().Next(1, 9999), curName, RequestStatus.невизначений, GetSpecialist(specList));
                Console.WriteLine("Запис створено. На звязку оператор {0}",req1.Specialist.Name);
                Console.WriteLine("Меню: \n");
                Console.WriteLine("1. Вiдправити повiдомлення");
                Console.WriteLine("2. Iнформацiя про запис");
                Console.WriteLine("0. Вихiд \n");
                int p = 0;
                do
                {
                    p = Convert.ToInt32(Console.ReadLine());
                    switch (p)
                    {
                        case 1:
                            {
                                Console.WriteLine("Введiть текст повiдомлення: ");
                                req1.SendMessage(req1.UserName, req1.Specialist.Name, Console.ReadLine());
                                Console.WriteLine("Повiдомлення вiдправлено.");
                                Thread.Sleep(1500);
                                Console.WriteLine("Вашу проблему вирiшено? (+ або -) ");
                                string answer = Console.ReadLine();

                                if (answer == "-") req1.Status = RequestStatus.невирiшений;
                                else if (answer == "+") req1.Status = RequestStatus.вирiшений;
                                else req1.Status = RequestStatus.невизначений;
                                Menu();
                                break;
                            }

                        case 2:
                            {
                                Console.WriteLine(req1);
                                Menu();
                                break;
                            }

                        case 0:
                            Console.WriteLine("Хорошого дня! \nЗакриття програми...");
                            break;
                        default:
                            Console.WriteLine("Неправильна кнопка.");
                            Menu();
                            break;

                    }


                } while (p != 0);
            }
            else
            {
                Console.WriteLine("Програму не активовано");
            }
            Console.ReadLine();
        }


        static List<SupportSpecialist> CreateList() 
        {
            var specList = new List<SupportSpecialist>();
            specList.Add(new SupportSpecialist("Максим", SpecialistStatus.free));
            specList.Add(new SupportSpecialist("Анатолiй", SpecialistStatus.busy));
            specList.Add(new SupportSpecialist("Дмитро", SpecialistStatus.free));
            specList.Add(new SupportSpecialist("Владислав", SpecialistStatus.busy));
            specList.Add(new SupportSpecialist("Оксана", SpecialistStatus.free));
            specList.Add(new SupportSpecialist("Вiкторiя", SpecialistStatus.busy));
            specList.Add(new SupportSpecialist("Олена", SpecialistStatus.free));
            specList.Add(new SupportSpecialist("Вiктор", SpecialistStatus.busy));
            specList.Add(new SupportSpecialist("Анна", SpecialistStatus.free));
            specList.Add(new SupportSpecialist("Олег", SpecialistStatus.busy));

            return specList;
        }
        static SupportSpecialist GetSpecialist(List<SupportSpecialist> list) 
        {
            SupportSpecialist currentSpec = list.Find(x => x.Status == SpecialistStatus.free);
            currentSpec.Status = SpecialistStatus.busy;
            return currentSpec;
        }

        static void Menu() 
        {
            Console.WriteLine("Для продовження натиснiть будь-яку клавiшу...");
            Console.ReadKey();
            Console.WriteLine("1. Вiдправити повiдомлення");
            Console.WriteLine("2. Iнформацiя про запис");
            Console.WriteLine("0. Вихiд \n");
        }
    }
    
}
