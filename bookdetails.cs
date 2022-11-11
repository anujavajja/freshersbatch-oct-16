using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class bookdetails
    {
        public static void Main()
        {
            int bookid;
            string title, bookType;
            double price;
            Console.Write("\nenter bookId :");
            bookid = int.Parse(Console.ReadLine());
            Console.Write("\nenter book title :");
            title = Console.ReadLine();
            Console.Write("\nThe type of book is : ");
            bookType = Console.ReadLine();
            Console.Write("\nThe price of the book = ");
            price = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nThe Book Id is :"+bookid);
            Console.Write("\nThe Book Title is :"+title);
            Console.Write("\nThe type of Book is :"+bookType);
            Console.Write("\nThe Book price ="+price);
            Console.Read();

        }
    }
}

