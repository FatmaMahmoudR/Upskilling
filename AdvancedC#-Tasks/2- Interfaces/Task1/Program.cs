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
            Console.WriteLine("Choose a payment method");
            Console.WriteLine("1.Bank Transfer \t 2.Credit Card \t 3.Paypal");
            int x = int.Parse(Console.ReadLine());

            IPaymentInterface payment;
            if (x == 1)
                payment = new BankTransfer();
            else if (x == 2)
                payment = new CreditCardPayment();
            else if (x==3)
                payment = new Paypal();
            else
            { //invalid option
                return;
            }
            payment.pay();

            Console.ReadKey();
        
        }
    }
}
