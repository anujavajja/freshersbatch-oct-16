using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class ArrayClass
    {
        public static void Main()
        {
            int[] array = { 10, 20, 30, 40, 50 };
            string[] array2 = new string[5];
            array2[0] = "anuja";
            array2[1] = "rani";
            array2[2] = "gopi";
            array2[3] = "topi";
            array2[4] = "sonu";
            int i;
            Console.WriteLine("------The int vales are---------");

            for (i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
            Console.WriteLine("-----The STRING Values------");
            foreach (string str in array2)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
            Console.WriteLine("-----The Copied Int/string Values are------");
            
            Console.WriteLine("----The Sorted Array-----");
            Array.Sort(array);
            for (i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
            foreach(string str in array2)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
            Console.WriteLine("------Clear the Array------------");
            Array.Clear(array, 1, 2);
            for (i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
            Console.WriteLine();
            Array.Clear(array2);
            foreach (string str in array2)
            {
                Console.WriteLine(str);
                Console.WriteLine();
            }
            Console.WriteLine("------REVERSED ARRAY------");
            Array.Reverse(array2);
            foreach (string str in array2)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("reversed array");
            Array.Reverse(array);
            for (i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
                
            

        
    }
}
