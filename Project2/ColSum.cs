using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class ColSum
    {
        public void sum()
        {
            int[,] matrix =
            {
                { 2, 4, 6 },
                { 2, 4, -2 },
               { 9, 8, 7 }

            };
            for (int i = 0; i < 3; i++)
            {
                int colSum = 0;
                for (int j = 0; j < 3; j++)
                {
                    colSum += matrix[i, j];

                }
                Console.WriteLine($"Sum of coloum{i + 1}:{colSum}");
            }

        }
    }
}
