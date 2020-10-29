using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_Laba_9_
{
    class Program
    {
        public static void start()
        {
            Console.WriteLine("Введите кол-во клиентов: ");
            int lenght = int.Parse(Console.ReadLine());
            ClientBank[] clients = new ClientBank[lenght];
            int selected;
            while (true)
            {
                Console.WriteLine("1) Ввод массива структур; ");
                Console.WriteLine("2) Изменение заданной структуры");
                Console.WriteLine("3) Удаление структуры из массива;");
                Console.WriteLine("4) Вывод на экран массива структур");
                Console.WriteLine("5) Специальный пункт 1");
                Console.WriteLine("6) Специальный пункт 2");
                Console.WriteLine("7) Выход\n");
                selected = int.Parse(Console.ReadLine());
                switch (selected)
                {
                    case 1:
                        {
                            Functions.inputInfo(clients);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите номер договора");
                            Functions.changeInfo(clients, int.Parse(Console.ReadLine()));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите номер договора");
                            Functions.deleteByFEE(clients, int.Parse(Console.ReadLine()));
                            break;
                        }
                    case 4:
                        {
                            Functions.printInfo(clients);
                            break;
                        }
                    case 5:
                        {
                            Functions.sumOfVkladov(clients);
                            break;
                        }
                    case 6:
                        {
                            Functions.sumOfVkladovForToday(clients);
                            break;
                        }
                    case 7:
                        {
                            return;
                        }
                }
            }
        }
        static void Main(string[] args)
        {
            start();
        }
    }
}
