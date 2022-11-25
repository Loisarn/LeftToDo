public class Task
{

    public string? newTask { get; set; }
    public List<Task> tasks = new List<Task>();
    public void Tasks()
    {

        Console.Clear();
        Console.WriteLine("Add task");
        newTask = Console.ReadLine();
        Task task = new Task();
        tasks.Add(task);

        return;
    }
}