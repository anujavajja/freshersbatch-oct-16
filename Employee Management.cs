using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class DelegateEmployee_Management
    {
        public double GrossSalary { get; set; }
        public static int TourAllowance { get; private set; }
        public static int TelephoneAllowance { get; private set; }

        public class Employee
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
            public double GrossSalary { get; set; }

            public void Details(int Empno, string EmpName, double salary)
            {
                this.Empno = Empno;
                this.EmpName = EmpName;
                this.salary = salary;
            }
            public virtual void EmployeeSalary()
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

                Console.WriteLine("Employee Number =" + Empno);
                Console.WriteLine("Employee name is " + EmpName);
                Console.WriteLine("Employee Salary = " + salary);
                Console.WriteLine("Employee HRA = " + HRA);
                Console.WriteLine("Employee TA = " + TA);
                Console.WriteLine("Employee DA = " + DA);
            }
            public void getGrossSalary()
            {
                this.GrossSalary = salary + HRA + TA + DA;
                Console.WriteLine("Employee GrossSalary =" + this.GrossSalary);

            }

            public virtual void CalculateSalary()
            {
                PF = (GrossSalary * 10) / 100;
                TDS = (GrossSalary * 18) / 100;
                NetSalary = (GrossSalary) - (PF + TDS);
                Console.WriteLine("Employee PF = " + PF);
                Console.WriteLine("Employee TDS = " + TDS);
                Console.WriteLine("Employee NetSalary =" + NetSalary);

            }
        }
        //manager class(child class)
        public class Manager : Employee
        {
             double Petrol_Allowance;
             double Food_Allowance;
            double Other_Allowance;

            
            public void CalculatingAllowance(double salary)
            {
                Petrol_Allowance = (salary * 18) / 100;
                Food_Allowance = (salary * 13) / 100;
                Other_Allowance = (salary * 3) / 100;
                Console.WriteLine("petrol Allowance =" + Petrol_Allowance);
                Console.WriteLine("food allowance =" + Food_Allowance);
                Console.WriteLine("other allowance =" + Other_Allowance);
                
            }
            public void setGrossSSalary()
            {
                GrossSalary = salary + Petrol_Allowance + Food_Allowance + Other_Allowance;
                Console.WriteLine("GrossSalary ="+GrossSalary);
            }
            public override void CalculateSalary()
            {
                base.CalculateSalary();
            }
        }
        class MarketingExecutive : Employee
        {
            int KiloMeterTravel;
            private int TourAllowance { get; set; }
            private int TelephoneAllowance { get; set; } 


            public void CalculateValues()
            {
                Console.WriteLine("----MarketingExecutive----------");
                Console.WriteLine("Enter Kilometers");
                int KilometerTravel = Convert.ToInt32(Console.ReadLine());
                 TourAllowance = KilometerTravel * 5;
                 TelephoneAllowance = 1000;
                Console.WriteLine("TourAllowance =" + TourAllowance);
                Console.WriteLine("TelephoneAllowance =" + TelephoneAllowance);
            }
            public void getGrossSalary(double salary, int TourAllowance, int TelephoneAllowance)
            {
                this.GrossSalary = salary + TelephoneAllowance + TourAllowance;
                Console.WriteLine("GrossSalary =" + this.GrossSalary);
            }
            public override void CalculateSalary()
            {
                base.CalculateSalary();
            }
        }

      
        public static void Main(string[] args)
        {

            int Empno;
            string EmpName;
            double salary;
            Console.WriteLine("-----ACCEPTING EMPLOYEE DETAILS-------");

            Console.WriteLine("Enter Employee number");
            Empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name  ");
            EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-------EMPLOYEE DETAILS--------------");
            DelegateEmployee_Management emp = new DelegateEmployee_Management();
            Employee e = new Employee();
            e.Details(Empno, EmpName, salary);
            e.EmployeeSalary();
            e.getGrossSalary();          
            e.CalculateSalary();

            Console.WriteLine("------MANAGER DETAILS--------------");
            Manager m = new Manager();
            m.CalculatingAllowance(salary);
            m.setGrossSSalary();
            m.CalculateSalary();
            MarketingExecutive mar = new MarketingExecutive();
         
            mar.CalculateValues();
            mar.getGrossSalary(salary, TourAllowance, TelephoneAllowance);
            mar.CalculateSalary();





        }
    }
}

