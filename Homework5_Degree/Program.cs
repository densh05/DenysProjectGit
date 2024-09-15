using System;
using System.Text;

//Відомо, що у чисел, які є ступенем двійки, тільки один біт має значення 1. Використовуючи Visual Studio, створіть проєкт по шаблону Console Application. Напишіть програму, яка виконуватиме перевірку – чи є вказане число ступенем двійки чи ні.

namespace Homework5_Degree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть число для перевірки");
            int number = Convert.ToInt32(Console.ReadLine());

            if ((number > 0) && ((number & (number - 1)) == 0))
            {
                Console.WriteLine("Введене число являється ступенем двійки.");
            }
            else
            {
                Console.WriteLine("Введене число не являється ступенем двійки.");
            }

        }
    }
}
