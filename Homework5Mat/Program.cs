using System;

//Є 3 змінні типу int x = 5, y = 10 і z = 15; Виконайте та розрахуйте результат наступних операцій для цих змінних:
// x += y >> x++ * z;
// z = ++x & y * 5;
// y /= x + 5 | z;
// z = x++ & y * 5;
// x = y << x++ ^ z;

namespace Homework5Mat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 5, y = 10, z = 15;

            x += y >> x++ * z;
            Console.WriteLine("x = " + x);

            z = ++x & y * 5;
            Console.WriteLine("z = " + z);

            y /= x + 5 | z;
            Console.WriteLine("y = " + y);

            z = x++ & y * 5;
            Console.WriteLine("z = " + z);

            x = y << x++ ^ z;
            Console.WriteLine("x = " + x);

        }
    }
}
