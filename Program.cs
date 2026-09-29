using System;
namespace Nexora;

static class Program
{
    static void Main(string[] args)
    {
        bool loop = true;

        while (loop)
        {
            Console.WriteLine("Please select an option:");
            Console.Write("1. list the inventory\n2. add an item\n3. remove an item\n0. exit\n");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    // List inventory
                    break;
                case "2":
                    // Add item
                    break;
                case "3":
                    // Remove item
                    break;
                case "0":
                    loop = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}