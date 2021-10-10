using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Part1.Task5
{
    class Program
    {
        //В массиве целых чисел найти разницу между средним арифметическим и значением минимального элемента.
        static void Main(string[] args)
        { 
            int[] array5 = new int[20];
            Random rndArray5 = new Random();
            float sum5 = 0;

            for (int i = 0; i<array5.Length; i++)
            {
                array5[i] = rndArray5.Next(-10, 10);
            }

            foreach (var item in array5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            for (int j = 0; j < array5.Length; j++)
            {
                sum5 = sum5 + array5[j];
            }
                int a12 = array5.Min();
                float avrg = sum5 / (array5.Length);
                float Differ = avrg - a12;
                Console.WriteLine("Average value " + avrg);
                Console.WriteLine("Difference    " + Differ);
    }
}
}
