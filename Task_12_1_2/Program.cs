using System;

namespace Task_12_1_2
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            var name = Console.ReadLine();
            string greetings = $"Привет, " + name;
            Console.WriteLine(greetings);

        }
    }
}
