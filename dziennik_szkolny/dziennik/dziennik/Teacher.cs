using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik
{
    public class Teacher : Person
    {
        public string Subject { get; set; }
        public Teacher(int id, string name, string subject) : base(id, name)
        {
            Subject = subject;
        }
    }
}
