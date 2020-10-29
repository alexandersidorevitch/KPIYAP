using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_Laba_9_
{
    class Functions
    {

        public static void changeInfo(ClientBank[] clients, int FEE)
        {
            for (int i = 0; i < clients.Length; i++)
            {
                if (clients[i].FEE == FEE)
                {
                    clients[i].changeInfo();
                }
            }
        }
        public static void inputInfo(ClientBank[] clients)
        {
            for (int i = 0; i < clients.Length; i++)
            {
                clients[i].changeInfo();
            }
        }
        public static void printInfo(ClientBank[] clients)
        {
            foreach (ClientBank client in clients)
            {
                client.printInfo();
            }
        }
        public static void sumOfVkladov(ClientBank[] clients)
        {
            double sum = 0;
            foreach (string Bank in Enum.GetNames(typeof(Banks)))
            {
                foreach (ClientBank client in clients.Where(el => el.bank.ToString() == Bank))
                {
                    sum += client.countMoney;
                }
                Console.WriteLine($"Всего вкладов в банк {Bank}: {sum}");
                sum = 0;
            }
        }
        public static void sumOfVkladovForToday(ClientBank[] clients)
        {
            double sum = 0;
            
            foreach (string Bank in Enum.GetNames(typeof(Banks)))
            {
                foreach (ClientBank client in clients.Where(el => el.bank.ToString() == Bank && el.dateLastChange.Date  == DateTime.Today))
                {
                    sum += client.countMoney;
                } 
                Console.WriteLine($"Всего вкладов в банк {Bank} за сегодня: {sum}");
                sum = 0;
            }
        }
        public static void deleteByFEE(ClientBank[] clients, int FEE)
        {
            for (int i = 0; i < clients.Length; i++)
            {
                if (clients[i].FEE == FEE)
                {
                    clients[i].deleteInfo();
                }
            }
        }
    }
}
