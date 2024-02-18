using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Konstruktor klasy Person
        protected Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
