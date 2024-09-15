using System;

class Program
{
    static void Main()
    {
        // Початковий масив
        int[] array = { 2, 3, 4, 5 };
        int newElement = 1;

        // Створення нового масиву на один елемент більше
        int[] newArray = new int[array.Length + 1];

        Array.Copy(array, 0, newArray, 1, array.Length);

        newArray[0] = newElement;

        Console.WriteLine(string.Join(", ", newArray)); 

        Console.ReadLine();
    }
}
