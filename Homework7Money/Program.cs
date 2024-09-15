using System;
using System.Text;

namespace Homework7Money
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть суму грошей у ГРН");
            double sum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть курс конвертації в Долларах");
            double exchange = Convert.ToDouble(Console.ReadLine());

            CalculateExchangeRate(sum, exchange);
        }

        static void CalculateExchangeRate(double sum, double exchange)
        {
           double result =  sum * exchange;
            Console.WriteLine($"Курс конвертацї: {result} ");  
        }
    }
}
