using System;

namespace LeftToDo
{
    public class TaskWithCheckList
    {
        public string? Name {get; set;}
        public string? Description {get; set;}

        public TaskWithCheckList (string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}