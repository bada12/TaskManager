using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    [Serializable]
    class ToDo
    {
        private bool isDone;
        public string Name { get; set; }
        public string Description { get; set; }

        public ToDo(string name = "empty", string description = "empty")
        {
            this.isDone = false;
            this.Name = name;
            this.Description = name;
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
            catch(Exception ex)
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void MarkDone()
        {
            isDone = true;
        }

        public void Editing()
        {
            EditName();
            EditDescription();
        }

        public override string ToString()
        {
            return String.Concat(
                   "\n------------------ ToDO ----------------------\n",
                   $"Name: {this.Name}\nDescription: {this.Description}\n" +
                   "----------------------------------------------\n"
            );
        }
    }
}
