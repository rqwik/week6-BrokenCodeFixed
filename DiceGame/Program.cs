using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Игра в кости
            //Компьюьер (cpu) и пользователь (user) играют в кости 
            //Компьютер "бросает кубик" и пользователь "бросает кубик" (за пользователя тоже играет класс рандом)
            //Значения, которые могут выпасть находятся в диапазоне от 1-6 (включительно)
            //Кто выбросил больший результат, то и победил в игре
            //бросок выполняется один раз
            //исправленный до рабочего состояния код дает до 10 пунктов 

            //комментарии к переменным: userThrow - бросок пользователем; cpuScore - бросок компьютера;


            Console.WriteLine("Game: User vs Computer");

            Random rnd = new Random();

            int userThrow = rnd.Next(1, 6);
            int cpuScore = rnd.Next(1, 6);

            Console.WriteLine($"Кости пользователя {userThrow}, кости компьютера {cpuScore}!");

            if (userThrow > cpuScore)
            {
                Console.WriteLine("Победил пользователь.");
            }

            else if (cpuScore > userThrow)
            {
                Console.WriteLine("Победил компьютер.");
            }
            else
            {
                Console.WriteLine("Ничья.");
            }
        }
    }
}