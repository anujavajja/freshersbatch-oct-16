using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class sum_of_two_numbers
    {
      
        public static void Main()
        {
          

                int[] Numbers = new int[5];
                int i, sum = 0;
                Console.WriteLine("enter elements :");
                for (i = 0; i < Numbers.Length; i++)
                {
                    Numbers[i] = int.Parse(Console.ReadLine());
                    sum = sum + Numbers[i];
                }
                Console.WriteLine("\nthe sum of integers is"+sum);
                Console.Read();

         

        }
    }
}

