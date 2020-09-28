using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Program
    {
        private static void multiplication_of_intervals(int beginning_first_interval, int end_first_interval, int beginning_second_interval, int end_second_interval)
        {
            for (int i = beginning_first_interval; i <= end_first_interval; i++)
            {
                for (int j = beginning_second_interval; j <= end_second_interval; j++)
                {
                    Console.Write($"{i * j} ");
                }
                Console.WriteLine("");
            }
        }
        private static void integerPart(double x, out int integerPart)
        {
            integerPart = (int)x;
        }
        static void Main(string[] args)
        {
            multiplication_of_intervals(2, 9, 0, 10);
            double x = 2.9999;
            int integer_part;
            integerPart(x, out integer_part);
            Console.WriteLine(integer_part);
            Console.ReadKey();
        }

    }
}
