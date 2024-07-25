using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class MatrixDemo
    { 
        public void matrix()
        {
            Console.WriteLine("Sum of 3x3 matrices");
            int[,] matrix1 = new int[3, 3];
            int[,] matrix2 = new int[3, 3];
            int[,] resmatrix = new int[3, 3];

            Console.WriteLine("enter the elements of the first 3x3 matrix");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"elements [{i},{j}]:");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("enter the elements of the second 3x3 matrix");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"elements[{i},{j}]:");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("result matrix");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resmatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                    Console.WriteLine(resmatrix[i, j]);
                }

            }
        }
    }
}
