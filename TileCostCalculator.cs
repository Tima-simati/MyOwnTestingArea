using System;
using System.Formats.Asn1;

namespace ConsoleApp1
{
    class TileCostCalculator
    {
        static void Main(string[] args)
        {
            // Introduction text
            Console.WriteLine("Hello and welcome to the Tile Cost Calculator!");
            // defining variables
            const double HOURLY_RATE = 86;           //86$/hour for 20 square feet
            const int TIME_PROGRESS = 20;            //work progress for tiling in 1h is 20squaremeter
            const string RECT_FLOOR = "rectangular"; //rectangular layout of floor
            const string TRI_FLOOR = "triangular";   //triangular layout of floor
            double area = 0;                             //variable for area

            //user input for floor plan shape
            Console.WriteLine("How does your floor plan look like? Is it rectangular or triangular?");
            string floorShape = Console.ReadLine();

            if (floorShape == RECT_FLOOR)
            {
                Console.WriteLine("Please enter the length of the rectangular floor plan");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the width of the rectangular floor plan");
                double width = Convert.ToDouble(Console.ReadLine());
                area = length * width; // area calculated         
            }
            if (floorShape == TRI_FLOOR)
            {
                Console.WriteLine("Please enter the baselength of the triangle floor");
                double baselength = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the heigth of the triangle floor");
                double height = Convert.ToDouble(Console.ReadLine());
                area = 0.5 * baselength * height;
            }
            if (floorShape != RECT_FLOOR || floorShape != TRI_FLOOR) //check for invalid input for floor shape
            {
                Console.WriteLine("No valid shape. Please enter a valid shape. Restart the calculator.");
            }

            Console.WriteLine("Please enter the cost of the tile per square foot");
            double costPerUnit = Convert.ToDouble(Console.ReadLine());
            double totalCost = area * (costPerUnit + (HOURLY_RATE / TIME_PROGRESS)); // variable for calculating total cost depending on area
            Console.WriteLine($"The total cost of tiling the area is: {totalCost}$");
        }
    }
}