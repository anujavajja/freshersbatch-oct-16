using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Account
    {
       public  int AccountNumber;
        public String CustomerName;
        public int Balance;
        public Account(int accountNumber, string customerName, int balance)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            Balance = balance;
        }
        int getBal()
        {
            return Balance;
        }
        public void Withdraw(int amt)
        {
            Console.WriteLine("Your Current Balance =" + Balance);
            Console.WriteLine("Withdraw Amount is" + amt);
            if (amt < Balance)
            {
                Console.WriteLine("Collect RS" + amt);
                Balance = Balance - amt;
            }
            else
                Console.WriteLine("Insufficient Balance");

        }
        public void Deposit(int Money)
        {
            if (Money > 0)
            {
                Balance = Balance + Money;
                Console.WriteLine(" Bank Balance =" + Balance);
            }
            else
            {
                Console.WriteLine(" Please Enter the correct Amount");
            }
            Console.WriteLine(" Bank Balance =" + Balance);
        }
        public void Bankbalance()
        {
            if (Balance == 0)
            {
                Console.WriteLine("Transaction cannot be continued asa balance is Zero in Your Account");
            }

            Console.WriteLine("Bank Balance =" + Balance);
        }
    
    
        public static void Main(string[] args)
        {
            Account account = new Account(1234567890, "Anuja", 0);
            account.Withdraw(3000);
            account.Deposit(1000);
            account.Bankbalance();
        }
    }
}
