using System;
using System.Linq;
using System.Collections.Generic;

namespace diagram_OOP
{
    public class Student: Person
    {

        protected string group { get; }
        protected List<Task> tasks;

        public Student(string Name, int Age, string Group) : base(Name, Age)
        {
            this.group = Group;
            this.tasks = new List<Task>();
        }

        public Student(string Name, int Age, string Group, List<Task> Tasks) : base(Name, Age)
        {
            this.group = Group;
            this.tasks = Tasks;
        }


        public void AddTask(string taskName, TaskStatus status)
        {
            tasks.Add(new Task(taskName, status));
        }


        public void RemoveTask(int index)
        {
           tasks.RemoveAt(index);
        }

        public void UpdateTask(int index, TaskStatus taskStatus)
        {
            Task oldTask = tasks[index];
            Task newTask = new Task(oldTask.Name, taskStatus);

            tasks[index] = newTask;
        }

        public string RenderTasks(string prefix = "\t")
        {
            string combinedString = "";

            for(int i =0;i<tasks.Count(); i++)
            {
                combinedString += $"{prefix} {i}. {tasks[i]}\n";
            }

            return combinedString;
        }

        private bool SequenceEqualTasks(List<Task> a, List<Task> b)
        {
            return a.SequenceEqual(b);
        }

        public bool Equals(Student other)
        {
            return name == other.name && age == other.age && group == other.group && SequenceEqualTasks(tasks, other.tasks);
        }

        public override string ToString() => $@"Student: {name} ({age} y.o.)
Group: {group}
Tasks:
{RenderTasks()}

";


    }
}
