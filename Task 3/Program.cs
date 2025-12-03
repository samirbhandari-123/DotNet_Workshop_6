using System;

namespace Task_3
{
    internal class Program
    {
        // Method that processes numbers based on a condition
        public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (int number in numbers)
            {
                if (condition(number))
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] numbers = { 5, 12, 7, 20, 3, 18, 10, 25 };

            Console.WriteLine("Original Numbers: " + string.Join(", ", numbers));

            // Print only even numbers
            Console.WriteLine("\nEven Numbers:");
            ProcessNumbers(numbers, n => n % 2 == 0);

            // Print only numbers greater than 10
            Console.WriteLine("\nNumbers Greater Than 10:");
            ProcessNumbers(numbers, n => n > 10);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
