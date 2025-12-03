using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Rectangle
    {
        private double length;
        private double breadth;

        // Expression-bodied properties
        public double Length
        {
            get => length;
            set => length = value;
        }

        public double Breadth
        {
            get => breadth;
            set => breadth = value;
        }

        // Expression-bodied method to calculate area
        public double Area() => length * breadth;

        // Expression-bodied method to calculate perimeter
        public double Perimeter() => 2 * (length + breadth);

        // Expression-bodied method to display rectangle details
        public string ShowDetails() =>
            $"Rectangle Details:\nLength: {length}\nBreadth: {breadth}\nArea: {Area()}\nPerimeter: {Perimeter()}";
    }
}
