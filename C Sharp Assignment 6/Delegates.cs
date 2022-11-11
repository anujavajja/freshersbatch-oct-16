using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment_6.Delegates;

namespace Assignment_6
{
    internal class Delegates
    {
        public delegate void EmployeeDelegate();
        public class MultiCastDelegate
        {
           public static Void Main(string[] args)
            {


                EmployeeDelegate empdel1 = new EmployeeDelegate(kilometerTravel);
                EmployeeDelegate empdel2 = new EmployeeDelegate(Tourallowance);
                EmployeeDelegate empdel3 = new EmployeeDelegate(Telephoneallowance);
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
        }
        public static void KilometerTravel()
        {
            int kt = 2;
            Console.WriteLine("Kilometer: {0}", kt);
        }
        public static void Tourallowance()
        {
            int kt = 2;
            int ta = (int)kt * 5;
            Console.WriteLine("Tourallowance:{0}", ta);
        }
        public static void Telephoneallowance()
        {
            int tpa = 1000;
            Console.WriteLine("Telephone Allowance:{0}", tpa);
        }
        public static void details()
        {
            int ID = 1;
            string name = "Rasna";
        int salary = 20000;
            Console.WriteLine("Marketingexecutive ID:{0}", ID);
            Console.WriteLine("MarketingExecutive Name:{0}, name);
            Console.WriteLine("MarketingExecutive salary:{0}, salary);
        }
    }
}
