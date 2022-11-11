using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class ICICIbank : Account
    {
        public ICICIbank(int accountNumber, string customerName, int balance) : base(accountNumber, customerName, balance)
        {
        }
        public void WithdrawAmount(int Amt)
        {
            if (Amt < Balance)
            {
                Balance -= Amt;
            }
            else if (Amt > Balance)
            {
                Console.WriteLine("Transaction cannot continued as balance is insufficient in Account");
            }

        }
    }
    class HDFCBank : Account
    {
        public HDFCBank(int accountNumber, string customerName, int balance) : base(accountNumber, customerName, balance)
        {
        }
        public void WithdrawAmount(int Amt)
        {
            if (Amt < Balance)
            {
                Balance -= Amt;
            }
            else if (Amt > Balance)
            {
                Console.WriteLine("insufficient Balance");
            }
            else if (Amt < 1000)
            {
                Console.WriteLine("Transaction cannot be continued below specified limit of Rs : -1000");
            }
        }

    }
}

