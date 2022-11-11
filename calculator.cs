using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class calculator
    {
       
    
        public static void Main()
        {
            int n1;
            int n2;
            int n3;
            int a = 0;
            Console.WriteLine("enter 1st number:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number :");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your choice:\n1-Add\n2-Subtract\n3-Multiplication\n4-division");
            n3 = int.Parse(Console.ReadLine());
            switch (n3)
            {
                case 1:
                    a = n1 + n2;
                    break;
                case 2:
                    a = n1 - n2;
                    break;
                case 3:
                    a = n1 * n2;
                    break;
                case 4:
                    a = n1 / n2;
                    break;
                default:
                    Console.WriteLine("enter correct choice");
                    break;
            }
            Console.WriteLine("your Answer is {0}", a);
            Console.ReadLine();
        }
    }
}

