using System;

namespace Part1.Task4
{
    class Program
    {
        //В массиве целых чисел утроить каждый положительный элемент, который стоит перед отрицательным.
        static void Main(string[] args)
        {
            int[] array4 = new int[20];
            Random rndArray4 = new Random();

            for (int i = 0; i < array4.Length; i++)
            {
                array4[i] = rndArray4.Next(-10, 10);
            }

            foreach (var item in array4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            for (int i = 0; i < array4.Length - 1; i++)
            {
                if (array4[i] > 0 && array4[i + 1] < 0)
                {
                    array4[i] = array4[i] * 3;
                }
            }

            foreach (var item in array4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine();
        }
    }
}
