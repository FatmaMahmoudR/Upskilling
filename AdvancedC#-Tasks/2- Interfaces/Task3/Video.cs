using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Video : IMedia
    {
        public void Play()
        {
            Console.WriteLine("Video is Playing");
        }

        public void Stop()
        {
            Console.WriteLine("Video stopped");
        }
    }
}
