using System;

namespace Task_12_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько элементов будет в массиве?");
            var count = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = Console.ReadLine();
            }
            Console.WriteLine("Все элементы записаны.");
        }
    }
}
