using System;
using System.Text;

namespace Homework8Credit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //allAmount = вся сума

            //paymenAmount = сума яку заплатили

            //remainingAmount = сума яку залишилось заплатити

            //numberPayment = скільки всього може бути платежів

            //overPayment = сума переплати

            Console.OutputEncoding = Encoding.Unicode;

            double allAmount = 700;

            double monthlyPayment = 100;

            int numberPayment = 7;

            Console.WriteLine("Введіть 2 суми яку хочете заплатити за кредит");
            double paymenAmount = double.Parse(Console.ReadLine());
            double paymenAmount2 = double.Parse(Console.ReadLine());

            CheсkStatusCredit( paymenAmount ,ref  allAmount, monthlyPayment, numberPayment);
            CheсkStatusCredit( paymenAmount2 ,ref allAmount, monthlyPayment, numberPayment);

        }

        static void CheсkStatusCredit(double paymenAmount ,ref double allAmount , double monthlyPayment , int numberPayment)
        {
            numberPayment --;
            allAmount -= paymenAmount;

            double overPayment = 0;
            if(paymenAmount > monthlyPayment)
            {
                overPayment = paymenAmount - monthlyPayment;
            }

            if(allAmount <= 0)
            {
                Console.WriteLine("Ви погасили кредит");
            }
            else if(numberPayment <= 0)
            {
                Console.WriteLine("Ви викорстали всі платежі,забаргованість {0} грн ", allAmount);
            }
            else
            {
                Console.WriteLine("Ваша сума заборгованості {0} грн " , allAmount);
                Console.WriteLine("Сума переплати {0} грн" , overPayment);
                Console.WriteLine("У вас залишилось {0} платежів" , numberPayment);
            }
            Console.ReadKey();
        }
    }
}
