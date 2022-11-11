using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class List_Collection
    {
        public static void Main()
        {
            List<Library_Project_Litware_Lib> employee = new List<Library_Project_Litware_Lib>();

            Console.WriteLine("---Employee Details---");
            Console.WriteLine();
            employee.Add(new Library_Project_Litware_Lib());
            ((Library_Project_Litware_Lib)employee[0]).Details(1, "Anuja", 17000);
            ((Library_Project_Litware_Lib)employee[0]).EmployeeSalary();
            ((Library_Project_Litware_Lib)employee[0]).CalculateSalary();
            Console.WriteLine();

            Console.WriteLine("---Employee Details---");
            Console.WriteLine();
            employee.Add(new Library_Project_Litware_Lib());
            ((Library_Project_Litware_Lib)employee[1]).Details(2, "Rashmi", 100000);
            ((Library_Project_Litware_Lib)employee[1]).EmployeeSalary();
            ((Library_Project_Litware_Lib)employee[1]).CalculateSalary();
            Console.WriteLine();



            Console.WriteLine("The total Number of Employees in the list =  " + employee.Count);



        }

    }
}
