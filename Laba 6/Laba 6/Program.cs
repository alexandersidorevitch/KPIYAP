using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[3];
            double[,] mat1 = new double[3, 3] {
                                                {1, 2, 3 },
                                                { 4, 5, 6 },
                                                { 7, 8, 9 }
                                                };
            double[,] mat2 = new double[3, 2] { { 6, 5 },
                                                { 4,3 },
                                                { 2, 1 } };
            //InOutArray.FillArray(numbers);
            Helper.PrintMatrix(Helper.Mul(mat1, mat2));
            Console.ReadKey();
        }
    }
}
