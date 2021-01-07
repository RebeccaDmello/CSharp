using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 2, 4, 6, 8, 10 };
            int[] array2 = { 2, 4, 6, 8, 10 };
            if (array1.Length != array2.Length)
            {
                Console.WriteLine("Arrays are not equal as their length is not same");
            }
            for(int i=0;i<array1.Length;i++)
            {
                if (array1[i] != array2[i])
                {
                    Console.WriteLine("Arrays are not Equal");
                    break;
                }
                else
                {
                    Console.WriteLine("Array are Equal");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
