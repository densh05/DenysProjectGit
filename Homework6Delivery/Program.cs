using System;
using System.Text;

namespace Homework6Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;

            int clientsCount;

            Console.WriteLine("Введіть кількість клієнтів:");

            do
            {
                clientsCount = int.Parse(Console.ReadLine());

                if (clientsCount < 1)
                {
                    Console.WriteLine("Помилка,введіть число більше 0");
                    Console.WriteLine("Введіть кількість клієнтів :");
                }

            } while (clientsCount < 1);

            Console.WriteLine("Ви ввели кількість клієнтів.");

            long routesCount = Factorial(clientsCount);

           
            Console.WriteLine($"Кількість можливих шлях : {routesCount}");

            Console.ReadKey();
        }

        static long Factorial(int n)
        {
            long result = 1;
            do
            {
                result *= n;
                n--;
            } while (n > 0);

            return result;


        }
    }
}
