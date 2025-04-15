using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class MediaPlayer
    {
        static void Main(string[] args)
        {
            IMedia v = new Video();
            IMedia A = new Audio();

            v.Play();
            A.Play();
            A.Stop();
            Console.ReadKey();

        }
    }
}
