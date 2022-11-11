using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignment6
{
    internal class Bank_Transactions
    {


        public static void Main()
        {
            try
            {
            start:
                Console.WriteLine("Please Enter which transactions you want to do\n 1.Bank\n 2.ICICIBank\n 3.HDFCBank\n 4.Exit");

                string ba = Console.ReadLine();
                if (ba.ToUpper() == "BANK")
                {
                    Bank_Transactions.BankTransaction();
                }
                else if (ba.ToUpper() == "ICICI") 
                {
                    Bank_Transactions.ICICIBanktransaction();
                }
                else if (ba.ToUpper() == "HDFC")
                {
                    Bank_Transactions.HDFCBanktransaction();
                }
                else if (ba.ToUpper() == "Exist")
                {
                    Console.WriteLine("Thank You");
                }
                else
                {
                    Console.WriteLine("select correct choice");
                    goto start;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }
        }

        public static void HDFCBanktransaction()
        {

            HDFCBank h = new HDFCBank(12345, "Anuja", 4000);
            h.Withdraw(6000);
            h.Deposit(5000);
        tran:
            Console.WriteLine("Please Enter which transactions you want to do\n 1.Bank\n 2.ICICIBank\n 3.HDFCBank\n 4.Exist");
            int Choice = Convert.ToInt32(Console.ReadLine());
            {
                if (Choice == 1)
                {
                    Console.WriteLine("Enter the Amount");
                    int amt = Convert.ToInt32(Console.ReadLine());
                    h.Deposit(amt);
                    goto tran;
                }
                else if (Choice == 2)
                {
                    Console.WriteLine("Enter the Amount");
                    int amt = Convert.ToInt32(Console.ReadLine());
                    h.Withdraw(amt);
                    goto tran;
                }
                else if (Choice == 3)
                {
                    h.Bankbalance();
                    goto tran;
                }
                else if (Choice == 4)
                {
                    Console.WriteLine("Thank you");
                }
                else
                {
                    Console.WriteLine("select Correct Choice");
                    goto tran;
                }

            }
        }

            public static void BankTransaction()
        {
            Account A = new Account(12345, "Anuja", 4000);
            A.Withdraw(6000);
            A.Deposit(5000);
        tran:
            Console.WriteLine("Please Enter which transactions you want to do\n 1.Bank\n 2.ICICIBank\n 3.HDFCBank\n 4.Exist");
            int Choice = Convert.ToInt32(Console.ReadLine());
            {
                if (Choice == 1)
                {
                    Console.WriteLine("Enter the Amount");
                    int amt = Convert.ToInt32(Console.ReadLine());
                    A.Deposit(amt);
                    goto tran;
                }
                else if (Choice == 2)
                {
                    Console.WriteLine("Enter the Amount");
                    int amt = Convert.ToInt32(Console.ReadLine());
                    A.Withdraw(amt);
                    goto tran;
                }
                else if (Choice == 3)
                {
                    A.Bankbalance();
                    goto tran;
                }
                else if (Choice == 4)
                {
                    Console.WriteLine("Thank you");
                }
                else
                {
                    Console.WriteLine("select Correct Choice");
                    goto tran;
                }
            }
        }
            public static void ICICIBanktransaction()
            {
                ICICIbank A = new ICICIbank(12345, "Anuja", 4000);
            A.Withdraw(6000);

            A.Deposit(5000);
            tran:
                Console.WriteLine("Please Enter which transactions you want to do\n 1.Bank\n 2.ICICIBank\n 3.HDFCBank\n 4.Exist");
                int Choice = Convert.ToInt32(Console.ReadLine());
                {
                    if (Choice == 1)
                    {
                        Console.WriteLine("Enter the Amount");
                        int amt = Convert.ToInt32(Console.ReadLine());
                        A.Deposit(amt);
                        goto tran;
                    }
                    else if (Choice == 2)
                    {
                        Console.WriteLine("Enter the Amount");
                        int amt = Convert.ToInt32(Console.ReadLine());
                        A.Withdraw(amt);
                        goto tran;
                    }
                    else if (Choice == 3)
                    {
                        A.Bankbalance();
                        goto tran;
                    }
                    else if (Choice == 4)
                    {
                        Console.WriteLine("Thank you");
                    }
                    else
                    {
                        Console.WriteLine("select Correct Choice");
                        goto tran;
                    }

                }

            }
        
        }
    }

