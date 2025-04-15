using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class SMS : INotification
    {
        public void Send_msg(string msg)
        {
            Console.WriteLine($"SMS: {msg}");
        }
    }
}
