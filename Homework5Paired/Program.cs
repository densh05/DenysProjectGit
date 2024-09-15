using System;

//Відомо, що у парних чисел молодший біт має значення 0. Використовуючи Visual Studio, створіть проєкт за шаблоном ConsoleApplication. Напишіть програму, яка виконуватиме перевірку чисел на парність.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        if ((number & 1) == 0)
        {
            Console.WriteLine("The number is paired");
        }
        else
        {
            Console.WriteLine("The number is not paired");
        }
    }
}
