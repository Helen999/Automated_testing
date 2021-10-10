using System;

namespace Part1.Task3
{
    class Program
    {
        //В массиве целых чисел заменить нулями отрицательные элементы.
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rndArray = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rndArray.Next(-10, 10);
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) 
                { 
                    array[i] = 0; 
                }
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
