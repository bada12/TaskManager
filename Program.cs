using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fkgeg");
            ToDo toDo = new ToDo() { Name = "Created new css-file" };
            Console.WriteLine(toDo.Name + " " + toDo.Description);
        }
    }
}
