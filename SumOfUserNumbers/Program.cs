using System;

namespace SumOfUserNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Сумма трех чисел
            //приложение предлагает пользователю ввести три числа и выводит на экран их сумму
            //исправленный до рабочего состояния код дает до 5 пунктов 
            Console.WriteLine("Please enter 3 random numbers and i will tell you the sum of these numbers");

            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a number:");
                int userResult = Convert.ToInt32(Console.ReadLine());
                sum += userResult;
            }

            Console.WriteLine($"Total: {sum}");
        }
    }
}