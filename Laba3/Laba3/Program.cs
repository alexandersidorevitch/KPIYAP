using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    class Program
    {
        private static string get_season(int month)
        {
            if (month > 0 && month <= 2 || month == 12)
            {
                return "зима";
            }
            else if (month <= 5)
            {
                return "весна";
            }
            else if (month <= 8)
            {
                return "лето";
            }
            else if (month <= 11)
            {
                return "осень";
            }
            else
            {
                return "Не верно введен месяц";
            }
        }
        private static double get_y(double k, double z)
        {
            double x = k < 1 ? k * Math.Pow(z, 3) : z * z + z;
            double y = Math.Log(1 + x * x) + Math.Pow(Math.Cos(x + 1), Math.Exp(k * x));
            return y;
        }
        private static string solution_of_equation(double a, double b)
        {
            int x1 = 0;
            if (a == 0 && b == 0)
            {
                return "Существует бесконечное множество решений";
            }
            if (a == 0 || b == 0 || -b / a < 0)
            {
                return $"Решение уравнения = {x1}";
            }
            double x2 = Math.Sqrt(-b / a);
            return $"Решения уравнения: {x1}; {x2}; {-x2};";

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            string x = Console.ReadLine();
            int month;
            if (int.TryParse(x,out month))
            {
                Console.WriteLine(get_season(month));
            }
            else
            {
                Console.WriteLine("Нужно было ввести целое число");
            }

            Console.Write("Введите k: ");
            string k = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Введите z: ");
            string z = Console.ReadLine();
            double k_double, z_double;
            if (double.TryParse(k, out k_double) && double.TryParse(z,out z_double))
            {
                Console.Write($"y = {get_y(k_double, z_double)}");
            }
            else
            {
                Console.WriteLine("Нужно было ввести число!");
            }

            Console.WriteLine();
            Console.Write("Введите a: ");
            string a = Console.ReadLine();

            Console.Write("Введите b: ");
            string b = Console.ReadLine();
            double a_double, b_double;
            if (double.TryParse(a, out a_double) && double.TryParse(b, out b_double))
            {
                Console.Write(solution_of_equation(a_double, b_double));
            }
            else
            {
                Console.WriteLine("Нужно было ввести число!");
            }

            Console.ReadKey();

        }
    }
}
