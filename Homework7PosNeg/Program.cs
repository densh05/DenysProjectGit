using System;
using System.Text;

namespace Homework7PosNeg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть число:");
            int number = Convert.ToInt32(Console.ReadLine());

            ChekNumber(number);
            ChekRemnant(number);
        }

        static void ChekNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Це число позитивне");
            }
            else if (number < 0)
            {
                Console.WriteLine("Це число негативне");
            }
            else
            {
                Console.WriteLine("Це число нуль");
            }
        }

        static void ChekRemnant(int number) // 2, 5, 3, 6, 9 
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Число ділиться на 2 без залишку");
            }
            else
            {
                Console.WriteLine("Число не ділиться на 2 без залишку");
            }

            if (number % 5 == 0)
            {
                Console.WriteLine("Число ділиться на 5 без залишку");
            }
            else
            {
                Console.WriteLine("Число не ділиться на 5 без залишку");
            }

            if (number % 3 == 0)
            {
                Console.WriteLine("Число ділиться на 3 без залишку");
            }
            else
            {
                Console.WriteLine("Число не ділиться на 3 без залишку");
            }

            if (number % 6 == 0)
            {
                Console.WriteLine("Число ділиться на 6 без залишку");
            }
            else
            {
                Console.WriteLine("Число не ділиться на 6 без залишку");
            }

            if (number % 9 == 0)
            {
                Console.WriteLine("Число ділиться на 9 без залишку");
            }
            else
            {
                Console.WriteLine("Число не ділиться на 9 без залишку");
            }
        }
    }
}
