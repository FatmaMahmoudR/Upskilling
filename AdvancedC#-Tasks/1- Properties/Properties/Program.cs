using Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            BankAccount Acc = new BankAccount(123,"test",5000);
            //Acc.Balance = 1;
            Acc.Withdraw(1000);
            Acc.Deposit(9000);
            Acc.Deposit(-500);
            Acc.Withdraw(2000);

            Console.ReadKey();

        }
    }
}
