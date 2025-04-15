using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "test msg";
            INotification sms = new SMS();
            INotification email = new Email();
            INotification push_notification = new PushNotification();

            sms.Send_msg(msg);
            email.Send_msg(msg);
            push_notification.Send_msg(msg);

            Console.ReadKey();

        }
    }
}
