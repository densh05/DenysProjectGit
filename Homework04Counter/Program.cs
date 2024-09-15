using System;
using System.Text;

namespace Homework04Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 100");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0 && number <= 14)
            {
                Console.WriteLine("This number belongs to the range [0-14]");
            }

            else if (number >= 15 && number <= 35)
            {
                Console.WriteLine("This number belongs to the range [15-35]");
            }

            else if (number >= 36 && number <= 50)
            {
                Console.WriteLine("This number belongs to the range [36-50]");
            }

            else if (number >= 51 && number <= 100)
            {
                Console.WriteLine("This number belongs to the range [51-100]");
            }

            else
            {
                Console.WriteLine("The number entered does not fit into any of the gaps");
            }

            Console.ReadLine();

        }
    }
}

