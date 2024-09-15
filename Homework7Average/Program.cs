using System;
using System.Text;

namespace Homework7Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть 3 числа:");

            Console.WriteLine("Введіть перше число:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть третє число:");
            int number3 = Convert.ToInt32(Console.ReadLine());

            Calculate(number1, number2, number3);
        }

        static void Calculate(int number1 , int number2 , int number3)
        {
            double average = (number1 + number2 + number3) / 3.0;
            Console.WriteLine($"Середнє арефметичне трьох чисел : {average}");
        }
    }
}
