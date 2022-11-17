using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ASSIGNMENT
{
    internal class Employee
    {
        int EmployeeID;
        string FirstName;
        string LastName;
        string Title;
        DateTime DOB;
        DateTime DOJ;
        string City;
        public Employee(int EmployeeID, string FirstName, string LastName, string Title, DateTime DOB, DateTime DOJ, string City)
        {
            this.EmployeeID = EmployeeID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Title = Title;
            this.DOB = DOB;
            this.DOJ = DOJ;
            this.City = City;

        }
        public int EmployeeId
        {
            get { return EmployeeID; }
            set { EmployeeID = value; }
        }
        public string Firstname
        {
            get { return FirstName; }
            set { FirstName = value; }
        }
        public string Lastname
        {
            get { return LastName; }
            set { LastName = value; }
        }
        public string title
        {
            get { return Title; }
            set { Title = value; }
        }
        public DateTime dob
        {
            get { return DOB; }
            set { DOB = value; }
        }
        public DateTime doj
        {
            get { return DOJ; }
            set { DOJ = value; }
        }
        public string city
        {
            get { return City; }
            set { City = value; }
        }
        public static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee(1001, "Malcolm", "Daruwalla", "Manager", new DateTime(1984, 11, 16), new DateTime(2011, 6, 8), "Mumbai"));
            empList.Add(new Employee(1002, "Asdin", "Dhalla", "AsstManager", new DateTime(1984, 8, 20), new DateTime(2012, 7, 7), "Mumbai"));
            empList.Add(new Employee(1003, "Madhavi", "Oza", "Consultant", new DateTime(1987, 11, 14), new DateTime(2015, 4, 12), "pune"));
            empList.Add(new Employee(1004, "Saba", "Shaikh", "SE", new DateTime(1990, 6, 3), new DateTime(2016, 2, 2), "Pune"));
            empList.Add(new Employee(1005, "Nazia", "Shaikh", "SE", new DateTime(1991, 3, 8), new DateTime(2016, 2, 2), "Mumbai"));
            empList.Add(new Employee(1006, "Amit", "Pathak", "Consultant", new DateTime(1989, 11, 7), new DateTime(2014, 8, 8), "Chennai"));
            empList.Add(new Employee(1007, "Vijay", "Natrajan", "Consultant", new DateTime(1989, 12, 2), new DateTime(2015, 6, 1), "Mumbai"));
            empList.Add(new Employee(1008, "Rahul", "Dubey", "Associate", new DateTime(1993, 11, 11), new DateTime(2014, 11, 6), "Chennai"));
            empList.Add(new Employee(1009, "Suresh", "Mistry", "Associate", new DateTime(1992, 8, 12), new DateTime(2014, 12, 3), "Chennai"));
            empList.Add(new Employee(1010, "Sumit", "Shah", "Manager", new DateTime(1991, 4, 12), new DateTime(2016, 1, 2), "Pune"));
            IEnumerable<Employee> displayQuery = from details in empList
                                                 select details;
            foreach (var emp in empList)
            {
                Console.WriteLine("Employees: {0},{1},{2},{3},{4},{5},{6}", emp.EmployeeId, emp.Firstname, emp.Lastname,emp.title, emp.dob, emp.doj, emp.city);
            }
            Console.WriteLine("----WHOSE LOCATION IS NOT MUMBAI----");
            IEnumerable<Employee> Query2 = from employee in empList
                                           where (employee.city != "Mumbai")
                                           select employee;
            foreach (var emp in Query2)
            {
                Console.WriteLine("Employees: {0},{1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.Firstname, emp.Lastname, emp.title, emp.dob, emp.doj, emp.city);
                
            }
            Console.WriteLine("----WHOSE TITLE IS ASSTMANAGER----");
            IEnumerable<Employee> Query3 = from employee in empList
                                           where employee.title == "AsstManager"
                                           select employee;
            foreach (var emp in Query3)
            {
               Console.WriteLine("Employees: {0}, {1},{2},{3},{4},{5},{6}", emp.EmployeeID,emp.Firstname,emp.Lastname,emp.title,emp.dob,emp.doj,emp.city);
            }
            Console.WriteLine("----Employee Name starts with S----");
            IEnumerable<Employee> Query4= from employee in empList
                                          where (employee.Lastname.StartsWith("S"))
                                          select employee;
            foreach (var emp in Query4)
            {
                Console.WriteLine("Employees: {0},{1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.Firstname, emp.Lastname, emp.title, emp.dob, emp.doj, emp.city);
            }
            Console.WriteLine("-------WHO HAVE JOINED BEFORE 1/1/2015-----");
            IEnumerable<Employee> Query5 = from employee in empList
                                           where employee.doj < (new DateTime(2015,1,1))
                                           select employee;
            foreach (var emp in Query5)
            {
                Console.WriteLine("Employees: {0},{1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.Firstname, emp.Lastname, emp.title, emp.dob, emp.doj, emp.city);
            }
            Console.WriteLine("----WHOSE DATE OF BIRTH IS AFTER 1/1/1990");
            IEnumerable<Employee> Query6 = from employee in empList
                                           where employee.dob > (new DateTime(1990,1,1))
                                           select employee;
            foreach (var emp in Query6)
            {
                Console.WriteLine("Employees: {0},{1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.Firstname, emp.Lastname, emp.title, emp.dob, emp.doj, emp.city);
            }
            Console.WriteLine("---WHOSE DESIGNATION IS CONSULTANT AND ASSOCIATE");
            IEnumerable<Employee> Query7 = from employee in empList
                                           where employee.Title == "Consultant" || employee.Title == "Associate"
                                           select employee;
                                          
            foreach (var emp in Query7)

            {
                Console.WriteLine("Employees: {0},{1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.Firstname, emp.Lastname, emp.title, emp.dob, emp.doj, emp.city);
            }
            Console.WriteLine("------ Total Count of employee--------");
            var result = empList.Count();
            {
                Console.WriteLine("Print the Result" + result);
            }
            Console.WriteLine("-------Count of employees belonging to Chennai------");
            var a =(from emp in empList where emp.city == "Chennai" select emp).Count();
            {
                Console.WriteLine("Print the Count " + a);
            }
            Console.WriteLine("-------Highest Employee ID from List--------");
            var b = empList.Max(em => em.EmployeeID);
            {
                Console.WriteLine("The Highest Employee ID is" + b);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Print total number of employees joined after 1/1/2015");
            var value = (from emp in empList where emp.doj>(new DateTime(2015/1/1)) select emp).Count();
            {
                Console.WriteLine("The total no of employees joined after 2015/1/1 : " + value);
            }   
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Total number of employee whose designation is not Associate");            var A = (from emp in empList where emp.title != "Associate" select emp).Count();
            {
                Console.WriteLine(A);
            }
            Console.WriteLine("------------ Group by City-----------------------");
            var empgrps = from emp in empList
                          group emp by emp.city;
            foreach(var group in empgrps)
            {
                Console.WriteLine("{0}-{1}",group.Key, group.Count());
            }
            Console.WriteLine("----------Group by City and Title--------------------");
           
             var Groups1 = from emp in empList
                          group emp by new { emp.city, emp.title };
            foreach (var cityTitle in Groups1)
            {
                Console.WriteLine(cityTitle.Key + ":");
                foreach (Employee emp in cityTitle)
                    Console.WriteLine("  " + emp.EmployeeID);
            }
            Console.WriteLine();
            
            Console.WriteLine("--------the youngest employee-------");
            var Youngest = empList.Select(em => em.DOB);
            Console.WriteLine("\n The Youngest Employee is :" + Youngest.Max());
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            Console.WriteLine("LINQ QUERIES ARE SUCCESSULLY COMPLETED");
                      


            Console.ReadKey();

        }
    }
}
