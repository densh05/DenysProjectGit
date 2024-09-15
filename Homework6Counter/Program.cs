using System;

namespace Homework6Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = 20;
            int height = 7;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");


            Console.ReadLine();
        }
    }
}

