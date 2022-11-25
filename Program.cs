using System;
using static Task;

public class Program
{
    private static void Main(string[] args)
    {
        bool running = true;



        while (running)
        {
            Console.WriteLine("\n\nWelcome to this To Do application! To navigate, choose a number. If you wish to exit, press any button and enter.\n");
            Console.WriteLine("1. Add a new Task");
            Console.WriteLine("2. Show todays task list");
            Console.WriteLine("3. Archive all done tasks");
            Console.WriteLine("4. Archived tasks list");

            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("What type of task do you want to add? Choose a number\n");
                        Console.WriteLine("1. Add a regular task");
                        Console.WriteLine("2. Task with deadline");
                        Console.WriteLine("3. Task with checklist");
                        Console.WriteLine("4. Cancel");

                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.Clear();
                                // regular task
                                break;
                        }
                    }
                    break;

                case 2:
                    // Show List 
                    break;
                case 3:
                    // Archive Tasks
                    break;
                case 4:
                    //Archived Tasks
                    break;
                default:
                    running = false;
                    break;
            }
        }
    }
}