using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_Laba_9_
{
    struct ClientBank
    {
        public string FIO;
        public Banks bank;
        public int FEE;
        public double countMoney;
        public DateTime dateLastChange;

        public void changeInfo()
        {
            Console.WriteLine("Введите ваше ФИО");
            FIO = Console.ReadLine();

            Console.WriteLine("Выберите банк (введите его номер)");
            int num = 1;
            foreach (string Bank in Enum.GetNames(typeof(Banks)))
            {
                Console.WriteLine($"{num++}){Bank}");
            }
            bank = (Banks)(int.Parse(Console.ReadLine()) - 1);

            Console.WriteLine("Введите номер счета");
            FEE = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите кол-во денег");
            countMoney = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите дату последнего изменения (дд.мм.гггг)");
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
