using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    class VectorOperations
    {
        private static int IndexOfMaxElement(double[] vector)
        {
            if (vector.Length == 0)
            {
                throw new Exception("Пустой массив");
            }

            int maxElementIndex = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[maxElementIndex] < vector[i])
                {
                    maxElementIndex = i;
                }
            }
            return maxElementIndex;
        }
        private static double[] SumTwoVectors(double[] firstVector, double[] secondVector)
        {
            if (firstVector.Length != secondVector.Length)
            {
                throw new Exception("Вектора разной длины");
            }

            double[] summaryVector = new double[firstVector.Length];
            for (int i = 0; i < firstVector.Length; i++)
            {
                summaryVector[i] = firstVector[i] + secondVector[i];
            }
            return summaryVector;
        }
        public static void Triangulate(double[] vector)
        {
            int count = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > 2 * i && vector[i] < 3 * i)
                {
                    Console.WriteLine($"Под условие подходит число {vector[i]}, его индекс: {i}");
                    count++;
                }
            }
            Console.WriteLine($"Всего таких чисел: {count}");
        }
        public static int MaxIndexOfSummary(double[] firstVector, double[] secondVector)
        {
            return IndexOfMaxElement(SumTwoVectors(firstVector, secondVector));
        }
        public static double MaxElementWithEvenIndex(double[] vector)
        {
            if (vector.Length <= 1)
            {
                throw new Exception("Длина массива должна быть 2 или больше");
            }

            double max = vector[1];
            for (int i = 1; i < vector.Length; i += 2)
            {
                if (max < vector[i])
                {
                    max = vector[i];
                }
            }
            return max;
        }

    }
}
