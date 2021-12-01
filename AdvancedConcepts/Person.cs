using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConcepts
{
    class Person
    {
        string name, surname;
        private ArrayList arPerson = new ArrayList();
        public Person()
        {

        }
        public Person this[int index]
        {
            get => (Person)arPerson[index];
            set => arPerson.Insert(index, value);
        }

        public string Name { get { return name; } }
        public string Surname { get { return surname; } set{ surname = value; } }

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
    }
}
