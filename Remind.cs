using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    [Serializable]
    class Remind
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }

        public Remind(string name = "empty", string description = "empty")
        {
            this.Name = name;
            this.Description = name;
            this.DeadLine = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                                DateTime.Now.Day, 23, 59, 59);
        }

        private void EditName()
        {
            char key;

            Console.Write("Do you want to edit name? ");
            try
            {
                key = Console.ReadLine().ToLower().ToCharArray().First();
                if (key == 'y')
                {
                    Console.Write("Enter new name: ");
                    Name = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void EditDescription()
        {
            char key;

            Console.Write("Do you want to edit description? ");
            try
            {
                key = Console.ReadLine().ToLower().ToCharArray().First();
                if (key == 'y')
                {
                    Console.Write("Enter new description: ");
                    Description = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void EditDeadLine()
        {
            char key;

            Console.Write("Do you want to edit deadline? ");
            try
            {
                key = Console.ReadLine().ToLower().ToCharArray().First();
                if (key == 'y')
                {
                    try
                    {
                        Console.Write("Enter new deadline day(yy-mm-dd): ");
                        string date = Console.ReadLine();
                        this.DeadLine = DateTime.Parse(date);

                        Console.Write("Enter new deadline time(hh:mm:ss): ");
                        string time = Console.ReadLine();
                        this.DeadLine = DateTime.Parse(String.Concat(date, " ", time));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Editing()
        {
            EditName();
            EditDescription();
            EditDeadLine();
        }

        public override string ToString()
        {
            return String.Concat(
                   "\n------------------ REMIND --------------------\n",
                   $"Name: {this.Name}\nDescription: {this.Description}\n" +
                   $"Deadline: {this.DeadLine.ToString()}\n" +
                   "----------------------------------------------\n"
            );
        }
    }
}
