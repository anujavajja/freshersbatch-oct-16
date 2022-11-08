using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class ArrayListClass
    {
        public static void Main()
        {
            Console.WriteLine("---Employee Details-----");
            ArrayList al = new ArrayList();
            al.Add(new Library_Project_Litware_Lib());
            ((Library_Project_Litware_Lib)al[0]).Details(1, "Anuja", 17000);
            ((Library_Project_Litware_Lib)al[0]).EmployeeSalary();
            ((Library_Project_Litware_Lib)al[0]).CalculateSalary();

            Console.WriteLine("---Employee Details---");

            al.Add(new Library_Project_Litware_Lib());
            ((Library_Project_Litware_Lib)al[0]).Details(2, "Gouthami", 17000);
            ((Library_Project_Litware_Lib)al[0]).EmployeeSalary();
            ((Library_Project_Litware_Lib)al[0]).CalculateSalary();





        }
    }
}
