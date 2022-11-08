using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public delegate void EmployeeDelegate();
    internal class Delegates
    {
      
          public static void Main(string[] args)
            {


                EmployeeDelegate empdel1 = new EmployeeDelegate(kilometerTravel);
                EmployeeDelegate empdel2 = new EmployeeDelegate(Tourallowance);
                EmployeeDelegate empdel3 = new EmployeeDelegate(TelephoneAllowance);
                EmployeeDelegate empdel4 = new EmployeeDelegate(details);
                EmployeeDelegate empdel5 = empdel1 + empdel2 + empdel3 + empdel4;
                empdel5();

            }
            public static void kilometerTravel()
            {
                int kt = 2;
                Console.WriteLine("Kilometertravel: {0}", kt);
            }
            public static void Tourallowance()
            {
                int kt = 2;
                int ta = kt = 5;
                Console.WriteLine("TourAllowance  :{0}", ta);
            }

            public static void TelephoneAllowance()
            {
                int tpa = 1000;
                Console.WriteLine("Telephone Allowance {0}", tpa);
            }
            public static void details()
            {
                int Id = 1;
                string name = "Anuja";
                int salary = 17000;
                Console.WriteLine("Marketing Executive ID :{0}", Id, name, salary);
            }
        }
    }

