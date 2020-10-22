using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    class Helper
    {
        private static double[] GetRow(double[,] matrix, int row)
        {
            if (row >= matrix.GetLength(0))
            {
                throw new Exception("Такой строки нет");
            }
            double[] vector = new double[matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                vector[i] = matrix[row, i];
            }
            return vector;
        }

        public static void PrintArray(double[] numbers, int countColumn = 1)
        {
            for (int i = 0; i < Math.Ceiling((double)numbers.Count() / countColumn); i++)
            {
                for (int j = 0; j < countColumn && i * countColumn + j < numbers.Count(); j++)
                {
                    Console.Write($"{numbers[i * countColumn + j]}  ");
                }
                Console.WriteLine();
            }
        }
        public static void PrintMatrix(double[,] numbers)
        {
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                PrintArray(GetRow(numbers, i), countColumn: numbers.GetLength(0));
            }
        }
        public static double FindMin(double[] numbers) { return numbers.Min(); }
        public static double FindMax(double[] numbers) { return numbers.Max(); }

        public static void Sort(double[] numbers, bool order)
        {
            double temp;
            for (int i = 0; i < numbers.Count() - 1; i++)
            {
                for (int j = i + 1; j < numbers.Count(); j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            if (order)
            {
                numbers.Reverse();
            }
            PrintArray(numbers);
        }
        public static double[] Mul(double[,] matrix, double[] array)
        {
            if (matrix.GetLength(1) != array.GetLength(0))
            {
                Console.WriteLine("Нельзя перемножить");
                return new double[] { };
            }
            double[] r = new double[1];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    r[i] += matrix[i, j] * array[i];

                }
            }
            return r;
        }
        public static double[,] Mul(double[,] matrixA, double[,] matrixB)
        {
            if (matrixA.GetLength(1) != matrixB.GetLength(0))
            {
                Console.WriteLine("Нельзя перемножить");
                return new double[,] { };
            }
            Console.WriteLine("Ваша матрица: ");

            var matrixC = new double[matrixA.GetLength(0), matrixB.GetLength(1)];

            for (var i = 0; i < matrixA.GetLength(0); i++)
            {
                for (var j = 0; j < matrixB.GetLength(1); j++)
                {
                    matrixC[i, j] = 0;

                    for (var k = 0; k < matrixA.GetLength(1); k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return matrixC;
        }
    }
}
