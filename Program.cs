using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Program
    {
        private static List<ToDo> toDos;
        private static List<Remind> reminds;
        private const string pathToDoTasks = "ToDo.txt";
        private const string pathRemindTasks = "Remind.txt";

        static Program()
        {
            toDos = new List<ToDo>();
            reminds = new List<Remind>();
        }

        static void Load()
        {
            using (FileStream fs = new FileStream(pathToDoTasks, FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                while(fs.Length != fs.Position)
                    toDos.Add((ToDo)formatter.Deserialize(fs));
            }
        }

        static void Main(string[] args)
        {
            Load();
            Console.WriteLine("*****\t\t\tTask Manager\t\t\t*****");
            try
            {
                while (true)
                {
                    PrintMenu();

                    int key;
                    int.TryParse(Console.ReadLine(), out key);

                    if (key <= 0 || key >= 13)
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

        static void PrintMenu()
        {
            Console.Write("1 - Show ToDo tasks\n");
            Console.Write("2 - Show Remind tasks\n");
            Console.Write("3 - Create ToDo task\n");
            Console.Write("4 - Create Remind task\n");
            Console.Write("5 - Edit ToDo task\n");
            Console.Write("6 - Edit Remind task\n");
            Console.Write("7 - Save ToDo tasks\n");
            Console.Write("8 - Save Remind tasks\n");
            Console.Write("9 - Mark Todo as done\n");
            Console.Write("10 - Mark Remind as done\n");
            Console.Write("11 - Delete Todo task\n");
            Console.Write("12 - Delete Remind task\n");
            Console.Write("other number`s to exit");
        }

        static void DoOperation(int key)
        {
            switch (key)
            {
                //Show all tasks
                case 1:
                    ShowToDoTasks();
                    break;

                //Show Remind Tasks
                case 2:
                    ShowRemindTasks();
                    break;

                //Create ToDo task
                case 3:
                    CreateToDo();
                    break;

                //Create Remind task
                case 4:
                    break;

                //Edit ToDo task
                case 5:
                    EditToDo();
                    break;

                //Edit Remind task
                case 6:
                    break;

                //Save ToDo tasks
                case 7:
                    SaveToDo();
                    break;

                //Save Remind tasks
                case 8:
                    break;

                //Mark Todo as done
                case 9:
                    MarkToDoAsDone();
                    break;

                //Mark Remind as done
                case 10:
                    break;

                //Delete Todo task
                case 11:
                    break;

                //Delete Remind task
                case 12:
                    break;
            }
        }

        static void ShowToDoTasks()
        {
            foreach (ToDo toDo in toDos)
                Console.WriteLine(toDo);
        }

        static void ShowRemindTasks()
        {
            foreach (Remind remind in reminds)
                Console.WriteLine(remind);
        }

        static void CreateToDo()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter description: ");
            string description = Console.ReadLine();
            toDos.Add(new ToDo(name, description));
        }

        static void EditToDo()
        {
            Console.WriteLine("******\t\t\t Edit ToDo \t\t\t*******");
            ShowToDoTasks();
            Console.Write("Which ToDo task do you want to edit?(enter number): ");

            int index;
            int.TryParse(Console.ReadLine(), out index);

            if (index >= 0 && index < toDos.Count)
                toDos[index].Editing();
        }

        static void SaveToDo()
        {
            using (FileStream fs = new FileStream(pathToDoTasks, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                foreach (ToDo toDo in toDos)
                    formatter.Serialize(fs, toDo);
            }
        }

        static void MarkToDoAsDone()
        {

        }
    }
}
