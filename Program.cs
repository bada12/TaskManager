using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Program
    {
        private static List<ToDo> toDos;
        private static List<Remind> reminds;

        static Program()
        {
            toDos = new List<ToDo>();
            reminds = new List<Remind>();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*****\t\t\tTask Manager\t\t\t*****");
            try
            {
                while (true)
                {
                    PrintMenu();

                    uint key;
                    uint.TryParse(Console.ReadLine(), out key);

                    if (key <= 0 || key >= 10)
                        break;

                    DoOperation(key);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n************* BYE *************");
        }

        static void DoOperation(uint key)
        {
            switch (key)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
            }
        }
        
        static void PrintMenu()
        {
            Console.Write("1 - Show all tasks\n");
            Console.Write("2 - Create ToDo task\n");
            Console.Write("3 - Create Remind task\n");
            Console.Write("4 - Edit ToDo task\n");
            Console.Write("5 - Edit Remind task\n");
            Console.Write("6 - Save all tasks\n");
            Console.Write("7 - Mark Todo as done\n");
            Console.Write("8 - Mark Remind as done\n");
            Console.Write("9 - Delete Todo task\n");
            Console.Write("10 - Delete Remind task\n");
        }
    }
}
