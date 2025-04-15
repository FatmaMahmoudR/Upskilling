using System.Xml.Serialization;

namespace Task4
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();

            int choice = 0;
            while (choice != -1)
            {
                Console.WriteLine("Enter: (1) for Type | (2) for undo | (3) for redo | (-1) for exit");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter Text: ");
                    string txt = Console.ReadLine();
                    editor.Type(txt);
                }
                else if (choice == 2)
                {
                    editor.Undo();
                }
                else if (choice == 3)
                {
                    editor.Redo();
                }
                else break;
            }
             
        }
    }
}
