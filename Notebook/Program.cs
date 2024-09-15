using System;
using System.Text;

namespace Homework8Credit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            double allAmount = 700;
            double monthlyPayment = 100;
            int numberPayment = 7;

            Console.WriteLine("Введіть суму, яку хочете заплатити за кредит:");
            double paymentAmount = double.Parse(Console.ReadLine());

            CheckStatusCredit(paymentAmount, allAmount, monthlyPayment, numberPayment);

            // Перевірка іншої суми платежу
            paymentAmount = 300;
            CheckStatusCredit(paymentAmount, allAmount, monthlyPayment, numberPayment);
        }

        static void CheckStatusCredit(double paymentAmount, double allAmount, double monthlyPayment, int numberPayment)
        {
            numberPayment--;
            allAmount -= paymentAmount;

            double overPayment = Math.Max(0, paymentAmount - monthlyPayment); // Перевірка на переплату

            if (allAmount <= 0)
            {
                Console.WriteLine("Ви погасили кредит.");
            }
            else if (numberPayment <= 0)
            {
                Console.WriteLine("Ви використали всі платежі, залишок боргу: {0} грн.", allAmount);
            }
            else
            {
                Console.WriteLine("Ваш залишок боргу: {0} грн.", allAmount);
                Console.WriteLine("Сума переплати: {0} грн.", overPayment);
                Console.WriteLine("У вас залишилось {0} платежів.", numberPayment);
            }
        }
    }
}
