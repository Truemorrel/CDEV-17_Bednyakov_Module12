using System;
using System.Collections.Generic;

namespace Task_12_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> array = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                array.Add(random.Next(1, 10));
            }
            array.Sort();
            // int[] array = {1,2,3,4,5,6,7,8,9};
            Console.Write("Дан массив: ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            var search = random.Next(0, 9);
            // int search = 1;
            Console.Write($"Элемент {search} ");
             int index = BinarySearch(search, array, 0, array.Count - 1);
            if (index == -1)
            {
                Console.WriteLine("не найден.");
            }
            else
            {
            Console.WriteLine($"имеет порядковый номер: {index}.");
            }
            Console.WriteLine();
        }
        public static int BinarySearch(int search, List<int> array, int left, int right)
        {
            int midle = (left + right) / 2; 
            while (array[midle] != search)
            {
                if ( right - left == 1)
                {
                    return -1;
                }  
                if (search < array[midle] )
                {
                    right = midle;
                    midle = ((midle) + left) / 2;
                }
                else  if (search > array[midle] )
                {
                    left = midle;
                    midle = ((midle) + right) / 2;
                }

            }
            return midle + 1;

         }
    }
}
