using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using System.Text;

namespace Text_Search_Engine
{
    internal class Program
    {
        static object locker = new object();
        static bool found = false;
        static void search(string textLine, string word, int line)
        {

            if (found) return;

            if (textLine.Contains(word))
            { 
                lock (locker)
                {
                    if (!found)
                    {
                        found = true;
                        Console.WriteLine($"found in line {line}");
                    }
                }
            }
            
        }
        static void Main(string[] args)
        {


            string text = @"Create a multi - threaded application that searches.
for a specific word in all lines of a given string.
Each thread should search in one line in the string.
If one thread finds the word, all threads should stop searching.";


            string target = "string";


            string[] textLines = text.Split('\n'); 



            for (int i = 0; i < textLines.Length; i++)
            {
                int idx = i;
                Thread t = new Thread(() => search(textLines[idx], target, idx+1));
                t.Start();
            }

        }
    }
}

