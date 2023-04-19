using System;

namespace LeftToDo
{
    public class TaskWithDeadLine
    {
        public string? Name {get; set;}
        public DateTime Deadline { get; set; }

        public TaskWithDeadLine(string name, DateTime deadline)
        {
            Name = name;
            Deadline = deadline;
        }

        public int GetDaysLeft()
        {
            TimeSpan timeLeft = Deadline - DateTime.Now;
            return(int)Math.Ceiling(timeLeft.TotalDays);
        }
    }
}