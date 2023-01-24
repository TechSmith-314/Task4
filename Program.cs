using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string userZodiacSign;
            string userAge;
            string userJob;

            Console.WriteLine("Как Вас зовут?");
            userName = Console.ReadLine();
            Console.WriteLine("Какой Ваш знак зодиака?");
            userZodiacSign = Console.ReadLine();
            Console.WriteLine("Где Вы работаете?");
            userJob = Console.ReadLine();
            Console.WriteLine("Сколько Вам лет?");
            userAge = Console.ReadLine();

            Console.WriteLine($"Вас зовут {userName}, Вам {userAge} год, Вы {userZodiacSign} и работаете на {userJob}.");
        }
    }
}
