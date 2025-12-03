using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_5
{
    // Class for cashier sales
    public class CashierSales
    {
        public string Name { get; set; }
        public double Sales { get; set; }

        public CashierSales(string name, double sales)
        {
            Name = name;
            Sales = sales;
        }
    }

    // Class for election applicants
    public class Applicant
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Applicant(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    // Class for music songs
    public class Music
    {
        public string Title { get; set; }
        public int DurationSeconds { get; set; }  // duration in seconds

        public Music(string title, int durationSeconds)
        {
            Title = title;
            DurationSeconds = durationSeconds;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // ---- Part 1: Aggregation Operators ----
            List<CashierSales> cashierSales = new List<CashierSales>
            {
                new CashierSales("Alice", 5000),
                new CashierSales("Bob", 7000),
                new CashierSales("Charlie", 6000),
                new CashierSales("David", 8000)
            };

            Console.WriteLine("--- Aggregation Operators ---");
            int totalCashiers = cashierSales.Count();
            double totalSales = cashierSales.Sum(c => c.Sales);
            double highestSale = cashierSales.Max(c => c.Sales);
            double lowestSale = cashierSales.Min(c => c.Sales);
            double averageSale = cashierSales.Average(c => c.Sales);

            Console.WriteLine($"Total Cashiers: {totalCashiers}");
            Console.WriteLine($"Total Sales: Rs.{totalSales}");
            Console.WriteLine($"Highest Sale: Rs.{highestSale}");
            Console.WriteLine($"Lowest Sale: Rs.{lowestSale}");
            Console.WriteLine($"Average Sale: Rs.{averageSale}\n");

            // ---- Part 2: Quantifier Operators ----
            List<Applicant> applicants = new List<Applicant>
            {
                new Applicant("Ethan", 20),
                new Applicant("Sophia", 17),
                new Applicant("Liam", 15),
                new Applicant("Olivia", 18)
            };

            Console.WriteLine("--- Quantifier Operators ---");
            bool anyUnder18 = applicants.Any(a => a.Age < 18);
            bool allAbove16 = applicants.All(a => a.Age > 16);

            Console.WriteLine($"Are there any applicants under 18? {anyUnder18}");
            Console.WriteLine($"Are all applicants above 16? {allAbove16}\n");

            // ---- Part 3: Element Operators ----
            List<Music> songs = new List<Music>
            {
                new Music("Song A", 180),  // 3 min
                new Music("Song B", 240),  // 4 min
                new Music("Song C", 300),  // 5 min
                new Music("Song D", 650),  // 10 min 50 sec
                new Music("Song E", 200)   // 3 min 20 sec
            };

            Console.WriteLine("--- Element Operators ---");
            var firstSong = songs.First();
            var lastSong = songs.Last();
            var firstAbove4Min = songs.First(s => s.DurationSeconds > 240);
            var firstAbove10Min = songs.FirstOrDefault(s => s.DurationSeconds > 600);

            Console.WriteLine($"First Song: {firstSong.Title}");
            Console.WriteLine($"Last Song: {lastSong.Title}");
            Console.WriteLine($"First Song Longer Than 4 Minutes: {firstAbove4Min.Title}");
            if (firstAbove10Min != null)
                Console.WriteLine($"First Song Longer Than 10 Minutes: {firstAbove10Min.Title}");
            else
                Console.WriteLine("No song longer than 10 minutes found.");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}


