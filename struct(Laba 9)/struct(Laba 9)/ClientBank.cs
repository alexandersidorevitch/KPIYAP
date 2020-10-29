using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_Laba_9_
{
    enum Banks
    {
        BelinvestBank,
        BelarusBank,
        DobrabitBank,
    }
    struct ClientBank
    {
        public string FIO;
        public Banks bank;
        public int FEE;
        public double countMoney;
        public DateTime dateLastChange;

        public void changeInfo()
        {
            Console.WriteLine("Введите ваше ");
            FIO = Console.ReadLine();

            Console.WriteLine("Выберите банк (введите его номер)");
            foreach (string Bank in Enum.GetNames(typeof(Banks)))
            {
                Console.WriteLine(Bank);
            }
            bank = (Banks)int.Parse(Console.ReadLine());

            Console.WriteLine("Введите номер счета");
            FEE = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите кол-во денег");
            countMoney = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите дату последнего изменения");
            dateLastChange = DateTime.Parse(Console.ReadLine());
        }
        public void printInfo()
        {
            Console.WriteLine($"ФИО: {FIO}");
            Console.WriteLine($"Банк {bank}");
            Console.WriteLine($"Номер счета {FEE}");
            Console.WriteLine($"Кол-во денег {countMoney}");
            Console.WriteLine($"Дата последнего измененния {dateLastChange}");
        }
        public void deleteInfo()
        {
            FIO = "";
            bank = (Banks)1;
            FEE = 0;
            countMoney = 0;
            dateLastChange = DateTime.Today;
        }
    }
}
