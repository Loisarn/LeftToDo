using System.Collections.Generic;

namespace LeftToDo
{
    public class Task
    {
        public string? Name { get; set; }

        public Task(string name)
        {
            Name = name;
        }
    }
}