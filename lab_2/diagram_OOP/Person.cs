using System;
namespace diagram_OOP
{
    public class Person: IEquatable<Person>
    {

        protected string name { get; }
        protected int age { get; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public bool Equals(Person other)
        {
            return name == other.name && age == other.age;
        }

        public override string ToString() => $"name: {name} age: {age} \n\n";

    }
}
