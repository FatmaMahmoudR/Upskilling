using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class PushNotification : INotification
    {
        public void Send_msg(string msg)
        {
            Console.WriteLine($"Push Notification: {msg}");
        }
    }
}
