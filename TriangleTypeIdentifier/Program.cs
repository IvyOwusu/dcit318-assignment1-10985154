 using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the first side of the triangle: ");
            string? input1 = Console.ReadLine();
            Console.Write("Enter the length of the second side of the triangle: ");
            string? input2 = Console.ReadLine();
            Console.Write("Enter the length of the third side of the triangle: ");
            string? input3 = Console.ReadLine();

            if (double.TryParse(input1, out double side1) && side1 > 0 &&
                double.TryParse(input2, out double side2) && side2 > 0 &&
                double.TryParse(input3, out double side3) && side3 > 0)
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter positive numerical values for the sides.");
            }
        }
    }
}
