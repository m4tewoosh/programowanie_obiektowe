using System;
namespace diagram_OOP
{
    public class Teacher: Person
    {
        public Teacher(string name, int age) : base(name , age)
        {
        }

        public override string ToString() => $"Teacher: {name} ({age} y.o.)";

    }
}
