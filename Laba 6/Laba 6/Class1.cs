using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    class InOutArray
    {
        public static void FillArray(double[] numbers)
        {
            for (int i = 0; i < numbers.Count(); i++)
            {
                Console.WriteLine($"Введите элемент {i + 1}");
                numbers[i] = (int.Parse(Console.ReadLine()));
            }
            PrintArray(numbers);
        }

        public static void PrintArray(double[] numbers, string name = null, int countColumn = 1)
        {
            if (name != null)
            {
                Console.WriteLine($"Исходный массив {name}:");
            }
            for (int i = 0; i < Math.Ceiling((double)numbers.Count() / countColumn); i++)
            {
                for (int j = 0; j < countColumn && i * countColumn + j < numbers.Count(); j++)
                {
                    Console.Write($"{numbers[i * countColumn + j]}  ");
                }
                Console.WriteLine();
            }
        }
        public static void RandomFillArray(double[] numbers)
        {

            Random rand = new Random();
            for (int i = 0; i < numbers.Count(); i++)
                numbers[i] = (rand.Next(1, 15));
            PrintArray(numbers);
        }
        
    }
}