using System;
namespace diagram_OOP
{
    public class Task: IEquatable<Task>
    {

        private string name;
        private TaskStatus status;

        public string Name { get => name; }

        public Task(string Name, TaskStatus Status)
        {
            this.name = Name;
            this.status = Status;
        }

        public bool Equals(Task other)
        {
            return name == other.name && status == other.status;
        }

        public override string ToString() => $"{name} status: [{status}]";

    }
}


public enum TaskStatus
{
    Waiting,
    Progress,
    Done,
    Rejected
}