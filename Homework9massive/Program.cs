using System;
using System.Text;

namespace Homework9massive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int[] array = { 1, 2, 3, 4, 5 }; //ініціалізація масиву
            int n = array.Length; //кількість елементів в масиві
            int index = 0; //місце на яке ставимо елемент

            int[] newArray = new int[n + 1]; //створення нового масиву на один елемент більше 

            newArray[index] = 0; //новий елемент

            for (int i = index; i < n; i++) //копіювання елементів
            {
                newArray[i + 1] = array[i];
            }

            //Виведеня масиву
            Console.WriteLine("Новий масив: " + string.Join(", ", newArray));
            Console.ReadLine(); //Затримка коду
        }
    }
}
