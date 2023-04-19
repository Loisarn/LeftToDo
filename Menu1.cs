namespace LeftToDo
{
    public class Menu1
    {
        public void FirstMenu()
        {
            bool running = true;

            while (running)
            {
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
                        Console.WriteLine("What type of task do you want to add?");
                        Console.WriteLine("1. Regular task");
                        Console.WriteLine("2. Task with deadline");
                        Console.WriteLine("3. Task with checklist");
                        Console.WriteLine("4. Cancel");

                        int taskChoice = Convert.ToInt32(Console.ReadLine());

                        switch (taskChoice)
                        {
                            case 1:
                                Console.WriteLine("Adding a regular task");
                                // code here
                                break;
                            case 2:
                                Console.WriteLine("Adding a task with a deadline");
                                // code
                                break;
                            case 3:
                                Console.WriteLine("Adding a task with a deadline");
                                // code
                                break;
                            default:
                                Console.WriteLine("Invalid option");
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Showing To do list");
                        // code
                        break;
                    case 3:
                        Console.WriteLine("Archiving tasks");
                        break;
                    case 4:
                        Console.WriteLine("Showing archived tasks");
                        break;
                    case 5:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}