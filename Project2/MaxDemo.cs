using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class MaxDemo
    {
        public void max()
        {
            int[] array = new int[5] { 1, 3, 6, 8, 30 };
            int max=array[0];
            for (int i = 0; i < array.Length; i++) {
                if (array[i] > max) {
                    max = array[i];
                    
                }
            }
            Console.WriteLine($"maximum element in an array:" );
            Console.WriteLine(max);
        }
    }
}
