using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_4
{
    // Book class for filtering the  example
    public class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string title, double price)
        {
            Title = title;
            Price = price;
        }
    }

    // Student class for sorting example
    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // ---- Part 1: Selecting / Projection ----
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(n => n * n).ToList();

            Console.WriteLine("Squared Numbers:");
            squaredNumbers.ForEach(n => Console.Write(n + " "));
            Console.WriteLine("\n");

            // ---- Part 2: Filtering (Where) ----
            List<Book> books = new List<Book>
            {
                new Book("Data and Web Development", 1200),
                new Book("Advanced Programming", 800),
                new Book("Application Development", 1500),
                new Book("Artificial Intelligence", 600)
            };

            var premiumBooks = books.Where(b => b.Price > 1000).ToList();

            Console.WriteLine("Premium Books (Price > Rs.1000):");
            foreach (var book in premiumBooks)
            {
                Console.WriteLine($"{book.Title} - Rs.{book.Price}");
            }
            Console.WriteLine();

            // ---- Part 3: Sorting (OrderBy) ----
            List<Student> students = new List<Student>
            {
                new Student("Samir"),
                new Student(""),
                new Student("Pratikshya"),
                new Student("Prabesh"),
                new Student("Nikesh"),
                new Student("Aarav"),
                new Student("Bikram"),
                new Student("Anjali"),
                new Student("Sujan"),
                new Student("Rohit")
            };

            var sortedStudents = students.OrderBy(s => s.Name).ToList();

            Console.WriteLine("Students Sorted Alphabetically (AAA Scholarship):");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
