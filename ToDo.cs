using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TaskManager
{
    [Serializable]
    class ToDo
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ToDo(string name = "empty", string description = "empty")
        {
            this.Name = name;
            this.Description = name;
        }

        public void Editing()
        {
            char key = 'n';

            Console.Write("Do you want to edit name? ");
            key = Console.ReadLine().ToLower().ToCharArray().First();
            if(key == 'y')
            {
                Console.Write("Enter new name: ");
                Name = Console.ReadLine();
            }

            Console.Write("Do you want to edit description? ");
            key = Console.ReadLine().ToLower().ToCharArray().First();
            if (key == 'y')
            {
                Console.Write("Enter new description: ");
                Description = Console.ReadLine();
            }
        }
    }
}
