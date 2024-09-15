using System;
using System.Text;

//іщє треба зробити щоб програма повторно запитувала числа А і Б якщо користувач неправильно вводить їх

namespace Homework6MoreLess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int a = 0;
            int b = 0;


            while (a >= b) // ymova
            {
                Console.WriteLine("Введіть два числа (А має бути менше В):");

                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

                if (a >= b)
                {
                    Console.WriteLine("Помилка,А має бути менше В");
                }

                else
                {
                    Console.WriteLine("Все правильно");
                    break;
                }
            }

            int counter = 0;

            for (int i = a + 1; i < b; i++) //ymova
            {
                if (i % 2 != 0)
                {
                    counter += i;
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine($"сума непарних чисел становить : {counter}");

            Console.ReadKey();
        }

    }
}
