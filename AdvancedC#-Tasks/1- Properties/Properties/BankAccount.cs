using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class BankAccount
    {
        public int AccountNumber { get;}
        public string HolderName { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int number, string name, double balance = 0)
        {
            AccountNumber = number;
            HolderName = name;
            Balance = balance;
        }

        public void Deposit(double Amount)
        {
            if(Amount <= 0)
            {
                Console.WriteLine("Invalid Amount");
                Console.WriteLine("------------------");
                return;
            }

            Balance += Amount;
            Console.WriteLine($"{Amount} is added successfuly");
            Console.WriteLine($"Balance : {Balance}");
            Console.WriteLine("------------------");
        }

        public void Withdraw(int Amount)
        {
            if (Amount <= 0)
            {
                Console.WriteLine("Invalid Amount");
                Console.WriteLine("------------------");
                return;
            }

            if (Balance< Amount)
                Console.WriteLine("There is not enough balance in your account.");
            else Balance -= Amount;

            Console.WriteLine($"Balance : {Balance}");
            Console.WriteLine("------------------");

        }
       

    }
}
