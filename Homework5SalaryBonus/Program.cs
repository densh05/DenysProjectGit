using System;
using System.Text;

namespace Homework5SalaryBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть заробітну плату робітника:");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть вислугу років робітника:");
            int yearsofwork = int.Parse(Console.ReadLine());

            double bonus = 0;

            if (yearsofwork < 5)
            {
                bonus = salary * 0.10;
            }

            else if (yearsofwork < 10)
            {
                bonus = salary * 0.15;
            }

            else if (yearsofwork < 15)
            {
                bonus = salary * 0.25;
            }

            else if (yearsofwork < 20)
            {
                bonus = salary * 0.35;
            }
             else if (yearsofwork < 25)
            {
                bonus = salary * 0.45;
            }

            else
            {
                bonus = salary * 0.50;
            }

            Console.WriteLine($"Бонус працівника становить {bonus:C}"); 
        }
    }
}
