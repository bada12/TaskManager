using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TaskManager
{
    class ToDo
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ToDo(string name = "empty", string description = "empty")
        {
            this.Name = name;
            this.Description = name;
        }
    }
}
