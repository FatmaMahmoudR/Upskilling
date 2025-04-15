using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Paypal : IPaymentInterface
    {
        public void pay()
        {
            Console.WriteLine("You have successfully paid using Paypal"); 
        }
    }
}
