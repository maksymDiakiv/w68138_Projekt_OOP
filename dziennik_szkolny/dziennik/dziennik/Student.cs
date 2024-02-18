using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik
{
    public class Student : Person
    {
        public int Grade { get; set; }

        
        public Student(int id, string name, int grade) : base(id, name)
        {
            Grade = grade;
        }
    }
}
