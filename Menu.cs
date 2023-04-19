using System.Globalization;

namespace LeftToDo
{
    public class Menu
    {
        #region Lists
        public List<Task> AllTasks = new List<Task>();
        public List<Task> ArchivedTasks = new List<Task>();
        public List<TaskWithCheckList> CheckListList = new List<TaskWithCheckList>();
        public List<TaskWithDeadLine> DeadLineList = new List<TaskWithDeadLine>();
        #endregion

        public void FirstMenu()
        {      
            bool running = true;

            while (running)
            {   
                Console.Clear();
                Console.WriteLine("Please choose an option");
                Console.WriteLine("1. Add a task");
                Console.WriteLine("2. To do list");
                Console.WriteLine("3. Archive tasks");
                Console.WriteLine("4. Archived tasks");
                Console.WriteLine("5. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    Console.Clear();
                        Console.WriteLine("What type of task do you want to add?");
                        Console.WriteLine("1. Regular task");
                        Console.WriteLine("2. Task with checklist");
                        Console.WriteLine("3. Task with deadline");
                        Console.WriteLine("4. Cancel");

                        int taskChoice = Convert.ToInt32(Console.ReadLine());

                        switch (taskChoice)
                        {
                            case 1:
                            Console.Clear();
                                Console.WriteLine("Adding a regular task");
                                 string? name = Console.ReadLine();
                                 
                                 Task task = new Task(name ?? "Invalid Taskname");
                                 AllTasks.Add(task);
                                break;
                            case 2:
                                Console.WriteLine("Adding a task with a checklist");
                                string? nameCheckList = Console.ReadLine();
                                string? description = Console.ReadLine();

                                TaskWithCheckList checklist = new TaskWithCheckList(nameCheckList ?? "Invalid", description ?? "Invalid description");
                                CheckListList.Add(checklist);
                                break;
                            case 3:
                                Console.WriteLine("Adding a task with a deadline");
                                string? nameDeadLine = Console.ReadLine();
                                Console.WriteLine("Enter deadline (MM/dd/yyyy):");
                                DateTime deadLine = DateTime.ParseExact(Console.ReadLine() ?? "", "MM/dd/yyyy", CultureInfo.InvariantCulture);

                                TaskWithDeadLine deadline = new TaskWithDeadLine(nameDeadLine ?? "Invalid", deadLine);
                                DeadLineList.Add(deadline);                            
                                break;
                            default:
                                Console.WriteLine("Invalid option");
                                break;
                        }
                        break;

                    case 2:
                    Console.Clear();
                        Console.WriteLine("All tasks:");
                        foreach (Task task in AllTasks)
                        {
                            Console.WriteLine("- " + task.Name);
                        }
                        Console.WriteLine();
                        foreach (TaskWithCheckList checklist in CheckListList)
                        {
                            Console.WriteLine($"Tasks with checklist: {checklist.Name}, Checklist: {string.Join(", ", checklist.Description)}");
                        }
                        Console.WriteLine();
                        foreach (TaskWithDeadLine deadline in DeadLineList)
                        {
                            Console.WriteLine($"Tasks with deadline: {deadline.Name}, Deadline: {deadline.Deadline} (Days left: {deadline.GetDaysLeft()})");
                        }
                                 Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Archiving tasks");
                        
                        break;
                    case 4:
                        Console.WriteLine("Showing archived tasks");
                        foreach (Task task in ArchivedTasks)
                        {
                            Console.WriteLine("- " + task.Name);
                        }
                        Console.ReadKey();
                        break;
                    case 5:
                        running = false;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}