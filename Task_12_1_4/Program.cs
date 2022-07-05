using System;

namespace Task_12_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой возрат");
            var age = Convert.ToInt16(Console.ReadLine());
            if (age > 13)
            {
                Console.WriteLine("Вы успешно зарегистрированы.");
            }
            else
            {
                Console.WriteLine("Пользователи младше 14 лет не могут быть зарегистрированы.");
            }
        }
    }
}
