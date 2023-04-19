using System;

namespace LeftToDo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome. In this application you'll be able to add to dos.");

            Menu Menu = new Menu();
            Menu.FirstMenu();

        }
    }
}