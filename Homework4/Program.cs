using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstvalue, twovalue;
            string operatorV; 

            Console.WriteLine("Enter the first value: ");
            firstvalue = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second value: ");
            twovalue = Double.Parse(Console.ReadLine());

            Console.WriteLine("Choose the method of operation: + or - or * or / or");
            operatorV = Console.ReadLine();

            switch (operatorV)
            {
                case "+":
                    Console.WriteLine(firstvalue + twovalue);
                    break; 

                case "-":
                    Console.WriteLine(firstvalue - twovalue);
                    break;

                case "*":
                    Console.WriteLine(firstvalue * twovalue);
                    break;

                case "/":
                    if (firstvalue == 0)
                        Console.WriteLine(0);
                    else if (twovalue == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine(firstvalue / twovalue);
                    break;

                default:
                    Console.WriteLine("Unknown command, please try again!");
                    break;
            }
            Console.ReadKey();
        }
    }
}


