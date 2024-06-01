using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age to view the price of ticket: ");
            string? input = Console.ReadLine();  
            int age;

            if (int.TryParse(input, out age) && age >= 0)
            {
                int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;

                Console.WriteLine($"The ticket price for age {age} is GHC{ticketPrice}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}

