using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_6
{
    // Class representing a tour booking
    public class TourBooking
    {
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public double Price { get; set; }
        public int DurationInDays { get; set; }
        public bool IsInternational { get; set; }

        public TourBooking(string customerName, string destination, double price, int durationInDays, bool isInternational)
        {
            CustomerName = customerName;
            Destination = destination;
            Price = price;
            DurationInDays = durationInDays;
            IsInternational = isInternational;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Sample tour bookings
            List<TourBooking> bookings = new List<TourBooking>
            {
                new TourBooking("Samir", "Paris", 15000, 7, true),
                new TourBooking("Aneesh", "Pokhara", 9000, 3, false),
                new TourBooking("Deepti", "Kathmandu", 12000, 5, false),
                new TourBooking("Roshan", "Tokyo", 20000, 6, true),
                new TourBooking("Ritesh", "Chitwan", 11000, 5, false),
                new TourBooking("Sudhan", "London", 25000, 8, true)
            };

            // ---- Filter tours above 10000 Rs and duration > 4 days ----
            var filteredTours = bookings
                .Where(b => b.Price > 10000 && b.DurationInDays > 4)
                .Select(b => new
                {
                    CustomName = b.CustomerName,
                    b.Destination,
                    Category = b.IsInternational ? "International" : "Domestic",
                    b.Price,
                    b.DurationInDays
                })
                .OrderBy(b => b.Category)  // Domestic first, then International
                .ThenBy(b => b.Price)      // Then sort by Price
                .ToList();

            // ---- Display the result ----
            Console.WriteLine("Filtered and Sorted Tour Bookings:\n");
            foreach (var tour in filteredTours)
            {
                Console.WriteLine($"Customer: {tour.CustomName}");
                Console.WriteLine($"Destination: {tour.Destination}");
                Console.WriteLine($"Category: {tour.Category}");
                Console.WriteLine($"Price: Rs.{tour.Price}");
                Console.WriteLine($"Duration: {tour.DurationInDays} days");
                Console.WriteLine(new string('-', 30));
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
