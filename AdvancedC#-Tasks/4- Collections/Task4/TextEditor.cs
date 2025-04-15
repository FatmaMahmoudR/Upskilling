using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{

    class TextEditor
    {
        Stack<string> undo, redo;

        public string text { get; set; }
        public TextEditor()
        {
            undo = new Stack<string>();
            redo = new Stack<string>();
            text = "";
        }

        public void Type(string newtxt)
        {
            undo.Push(text);
            text = newtxt;
            redo.Clear();

            Console.WriteLine($"Current Text: {text}");

        }


        public void Undo()
        {
            if (undo.Count > 0)
            {
                redo.Push(text);
                text = undo.Pop();
            }
            else
            {
                Console.WriteLine("undo is invalid");
            }
            Console.WriteLine($"Current Text: {text}");
        }

        public void Redo()
        {
            if (redo.Count > 0)
            {
                undo.Push(text);
                text = redo.Pop();
            }
            else
            {
                Console.WriteLine("Redo is Invalid");
            }
            Console.WriteLine($"Current Text: {text}");
        }




}
}
