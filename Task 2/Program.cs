using System;

namespace Task_2
{
    // Delegate that accepts two integers and returns an integer
    public delegate int Calculate(int a, int b);

    // Delegate that accepts a double price and returns a double
    public delegate double DiscountStrategy(double price);

    internal class Program
    {
        // Methods for arithmetic operations
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;

        // Discount methods
        public static double FestivalDiscount(double price) => price * 0.8;   // 20% off
        public static double SeasonalDiscount(double price) => price * 0.9;   // 10% off
        public static double NoDiscount(double price) => price;                // No discount

        static void Main(string[] args)
        {
            // --- Part 1: Custom Delegate for Add and Subtract ---
            Calculate calc;

            calc = Add;
            Console.WriteLine($"Add(10, 5) = {calc(10, 5)}");

            calc = Subtract;
            Console.WriteLine($"Subtract(10, 5) = {calc(10, 5)}");

            // --- Part 2: Discount Strategy ---
            double originalPrice = 1000;

            Console.WriteLine($"\nOriginal Price: {originalPrice}");
            Console.WriteLine($"Festival Discount(20% off): {FestivalDiscount(originalPrice)}");
            Console.WriteLine($"Seasonal Discount(10% off): {SeasonalDiscount(originalPrice)}");
            Console.WriteLine($"No Discount: {NoDiscount(originalPrice)}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
