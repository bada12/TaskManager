using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
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
    }
}
