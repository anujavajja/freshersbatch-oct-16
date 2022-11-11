using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Library_Project_Litware_Lib
    {
            public int Empno;
            public string EmpName;
            public double salary;
            public double HRA;
            public double TA;
            public double DA;
            public double PF;
            public double TDS;
            public double NetSalary;
            public double GrossSalary;

            public void Details(int Empno, string EmpName, double salary)
            {
                this.Empno = Empno;
                this.EmpName = EmpName;
                this.salary = salary;
            }
            public string tostring()
            {
                return this.EmpName;
            }
            public int toint32()
            {
                return this.Empno;
            }
            public double todouble()
            {
                return this.salary;
            }

            public void EmployeeSalary()
            {
                if (salary > 0 & salary < 5000)
                {
                    HRA = (salary * 10) / 100;
                    TA = (salary * 5) / 100;
                    DA = (salary * 15) / 100;
                }
                else if (salary >= 5000 & salary < 10000)
                {
                    HRA = (salary * 15) / 100;
                    TA = (salary * 10) / 100;
                    DA = (salary * 20) / 100;
                }
                else if (salary >= 10000 & salary <= 15000)
                {
                    HRA = (salary * 20) / 100;
                    TA = (salary * 15) / 100;
                    DA = (salary * 25) / 100;
                }
                else if (salary > 15000 & salary < 20000)
                {
                    HRA = (salary * 25) / 100;
                    TA = (salary * 20) / 100;
                    DA = (salary * 30) / 100;
                }
                else if (salary >= 20000)
                {
                    HRA = (salary * 30) / 100;
                    TA = (salary * 25) / 100;
                    DA = (salary * 35) / 100;
                }
                GrossSalary = salary + HRA + TA + DA;
                Console.WriteLine("Employee Number =" + Empno);
                Console.WriteLine("Employee name is " + EmpName);
                Console.WriteLine("Employee Salary = " + salary);
                Console.WriteLine("Employee HRA = " + HRA);
                Console.WriteLine("Employee TA = " + TA);
                Console.WriteLine("Employee DA = " + DA);
                Console.WriteLine("Employee GrossSalary = " + GrossSalary);

            }
            public void CalculateSalary()
            {
                PF = (GrossSalary * 10) / 100;
                TDS = (GrossSalary * 18) / 100;
                NetSalary = (GrossSalary) - (PF + TDS);
                Console.WriteLine("Employee PF = " + PF);
                Console.WriteLine("Employee TDS = " + TDS);
                Console.WriteLine("Employee NetSalary =" + NetSalary);
            }


        }
        class Program
        {

            public static void Main(string[] args)
            {
                int Empno;
                string EmpName;
                double salary;
                Console.WriteLine("Enter Employee number");
                Empno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name  ");
                EmpName = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary ");
                salary = Convert.ToDouble(Console.ReadLine());
                Library_Project_Litware_Lib e = new Library_Project_Litware_Lib();
                e.Details(Empno, EmpName, salary);
                e.EmployeeSalary();
                e.CalculateSalary();

            }
        }
    }
