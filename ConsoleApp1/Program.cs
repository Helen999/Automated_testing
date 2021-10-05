using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//В массиве целых чисел поменять местами максимальный отрицательный элемент и минимальный положительный.

namespace ConsoleApp1
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

            // First task

            int a = array.Min();
            int b = array.Max();
            for (int k = 0; k < array.Length - 1; k++)
            {
                if (array[k] < a && array[k] < 0)
                {
                    a = array[k];
                }
                if (array[k] > 0 && array[k] < b)
                { b = array[k]; }
            }
            for (int k = 0; k < array.Length; k++)
            {
                if (array[k] == a) { array[k] = b; }
                else if (array[k] == b) { array[k] = a; }

            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
