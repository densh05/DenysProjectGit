using System;
using System.Text;


namespace Homework4Translator
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            string value = "";
            while (value != "exit")
            {
                Console.WriteLine("Введіть слово яке хочете перевести: Сонце,Хмарно,Дощ,Сніг,Туман,Вітер,Град,Блискавка,Тепло,Холодно");
                string weathername = Console.ReadLine();
                switch (weathername)
                {
                    case "Сонце":
                        Console.WriteLine("Sun");
                        break;

                    case "Хмарно":
                        Console.WriteLine("Cloudy");
                        break;

                    case "Дощ":
                        Console.WriteLine("Rain");
                        break;

                    case "Сніг":
                        Console.WriteLine("Snow");
                        break;

                    case "Туман":
                        Console.WriteLine("Fog");
                        break;

                    case "Вітер":
                        Console.WriteLine("Wind");
                        break;

                    case "Град":
                        Console.WriteLine("Hail");
                        break;

                    case "Блискавка":
                        Console.WriteLine("Lightning");
                        break;

                    case "Тепло":
                        Console.WriteLine("Warm");
                        break;

                    case "Холодно":
                        Console.WriteLine("Cold");
                        break;

                    default:
                        Console.WriteLine("Невідоме слово,будь ласка,спробуйте ще раз");
                        break;

                }

                Console.WriteLine("Щоб вийти з програми,введіть - exit ");
                value = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Дякую за використання перекладача. До побачення!");
            Console.ReadLine();

        }
    }
}
