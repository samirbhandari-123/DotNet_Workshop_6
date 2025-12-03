using System;

namespace Task_2_1
{
    // Delegate that takes a price and returns the discounted price
    public delegate double DiscountStrategy(double price);

    internal class Program
    {
        // Discount methods
        public static double FestivalDiscount(double price) => price * 0.8;   // 20% off
        public static double SeasonalDiscount(double price) => price * 0.9;   // 10% off
        public static double NoDiscount(double price) => price;                // No discount

        // Method to calculate final price using a discount strategy
        public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy) =>
            strategy(originalPrice);

        static void Main(string[] args)
        {
            double originalPrice = 1000;

            Console.WriteLine($"Original Price: {originalPrice}");

            // ---- Part 2.2: Using predefined discount methods ----
            Console.WriteLine($"Festival Discount: {CalculateFinalPrice(originalPrice, FestivalDiscount)}");
            Console.WriteLine($"Seasonal Discount: {CalculateFinalPrice(originalPrice, SeasonalDiscount)}");
            Console.WriteLine($"No Discount: {CalculateFinalPrice(originalPrice, NoDiscount)}");

            // ---- Part 2.3: Using a lambda expression for 30% discount ----
            double lambdaDiscountPrice = CalculateFinalPrice(originalPrice, price => price * 0.7);
            Console.WriteLine($"Lambda 30% Discount: {lambdaDiscountPrice}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
