using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Audio : IMedia
    {
        public void Play()
        {
            Console.WriteLine("Audio is Playing");
        }

        public void Stop()
        {
            Console.WriteLine("Audio stopped");
        }
    }
}
