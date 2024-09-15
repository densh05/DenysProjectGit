using System;

//Використовуючи Visual Studio, створіть проєкт за шаблоном Console Application. Використовуючи теорему Де Моргана, перетворіть вихідний вираз A | B, в еквівалентний вираз.

namespace Homework5Theorem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = false;

            if (!A || !B) //true
                Console.WriteLine($"A || B = {A || B}");
            else
                Console.WriteLine($"A || B = {A || B}");

            if (!(A && B)) //false
                Console.WriteLine($"(A && B) = {(A && B)}");
            else
                Console.WriteLine($"(A && B) = {(A && B)}");

            Console.ReadKey();
        }
    }
}
