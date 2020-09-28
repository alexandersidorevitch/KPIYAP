using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    class Program
    {
        private static double square(double a, double b, double alpha)
        {
            double radian = alpha * Math.PI / 180;
            return Math.Abs((a * a - b * b)) * Math.Tan(radian) / 2.0;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите alpha: ");
            double alpha = double.Parse(Console.ReadLine());
            Console.WriteLine($"Площадь равна = {square(a, b, alpha)}");
            Console.ReadKey();
        }
    }
}
