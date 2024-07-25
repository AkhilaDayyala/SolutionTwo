using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class RowSum
    {
        public  void sum()
        {
            int[,] matrix =  {
            { 1, 2, 3 },
            { 4, 5, 6},
            { 7, 8, 9}

                };
            for (int i = 0; i < 3; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < 3; j++)
                {
                    rowSum = rowSum + matrix[i, j];
                }
                Console.WriteLine($"Sum of row {i + 1}: {rowSum}");
            }   }

    }
}
