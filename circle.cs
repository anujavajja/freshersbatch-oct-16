using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class circle
    {
       
        public static void Main()
        {

            int length, breadth, area, perimeter;
            Console.Write("\nenter length of the circle :");
            length = int.Parse(Console.ReadLine());
            Console.Write("\nenter breadth of the circle :");
            breadth = int.Parse(Console.ReadLine());
            area = length * breadth;
            perimeter = 2 * (length + breadth);
            Console.Write("\nArea of the circle is "+area);
            Console.Write("\nCircumference of the circle is "+perimeter);
            Console.Read();

        }
    }
}
