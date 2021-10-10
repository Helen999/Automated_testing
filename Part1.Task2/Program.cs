using System;

namespace Part1.Task2
{
    class Program
    {
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
            Console.WriteLine();

            int sum = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                sum = sum + array[i];
            }
            Console.WriteLine("The sum of numbers on even indexes is: " + sum);

            Console.WriteLine();
        }
    }
}