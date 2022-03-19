using System.Collections.Generic;

namespace diagram_OOP
{
    public class Classroom
    {

        private string name;
        private Person[] persons;

        public Classroom(string Name, Person[] Persons)
        {
            this.name = Name;
            this.persons = Persons;
        }

        public override string ToString() =>
            $@"Classroom: {name}
            {string.Join("\n", new List<Person>(persons))}";

    }
}
