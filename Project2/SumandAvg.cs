using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class SumandAvg
    {
      public   void avg()
        {
        int[] array = new int[10] {5, 10,15,85, 20, 30, 40, 50, 60, 10 };
        int sum = 0;
        for(int i=0; i<array.Length;i++){
            sum=sum+array[i];
           
            }
    Console.WriteLine("sum of array elements"+ sum);

            int avg = sum / 2;
            Console.WriteLine("Avg of array elements" + avg);

            }
}
}

