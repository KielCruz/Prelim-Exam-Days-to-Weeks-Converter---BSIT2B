using System;
using System.Text;
using System.Threading.Tasks;

namespace DaystoWeeksConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of days: ");

            if (int.TryParse(Console.ReadLine(), out int totalDays))
            {
                int weeks = totalDays / 7;
                int remainingDays = totalDays % 7;

                Console.WriteLine($"Weeks: {weeks}");
                Console.WriteLine($"Remaining days: {remainingDays}");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}