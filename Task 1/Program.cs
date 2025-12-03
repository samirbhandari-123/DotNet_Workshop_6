using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Rectangle object
            Rectangle rect = new Rectangle();

            // Get user input
            Console.Write("Enter length: ");
            rect.Length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter breadth: ");
            rect.Breadth = Convert.ToDouble(Console.ReadLine());

            // Display rectangle details
            Console.WriteLine(rect.ShowDetails());

            // Keep console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
