using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentProgram
{
    class Program
    {
        static void OpenProgram(string key)
        {
            if (key == "Basic")
            {
                DocumentProgram document1 = new DocumentProgram();
                document1.OpenDocument();
                document1.EditDocument();
                document1.SaveDocument();
            }
            else if (key == "Pro")
            {
                DocumentProgram document2 = new ProDocumentProgram();
                document2.OpenDocument();
                document2.EditDocument();
                document2.SaveDocument();
            }
            else if (key == "Expert")
            {
                DocumentProgram document3 = new ExpertDocumentProgram();
                document3.OpenDocument();
                document3.EditDocument();
                document3.SaveDocument();
            }
            else
            {
                Console.WriteLine("0");
            }
        }

        public static void PrintMenu()
        {
            Console.WriteLine("Select the version of Document Program you want to use: ");
            Console.WriteLine("1. Basic");
            Console.WriteLine("2. Pro");
            Console.WriteLine("3. Expert");
            Console.WriteLine("0. Exit");
        }

        static void Main(string[] args)
        {
            bool b = true;
            while (b)
            {
                PrintMenu();
                string op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        OpenProgram(Key.Basic);
                        break;
                    case "2":
                        OpenProgram(Key.Pro);
                        break;
                    case "3":
                        OpenProgram(Key.Expert);
                        break;
                    case "0":
                        b = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
