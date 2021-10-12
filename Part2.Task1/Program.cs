using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of lines: ");

            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[numberOfLines];
            for (int i = 0; i < numberOfLines; i++)
            {
                array[i] = Console.ReadLine();
            }

            int itemLong = 0; 
            int itemShort= 0;
            string longest ="";
            string shortest = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (itemLong < array[i].Length)
                {
                    itemLong = array[i].Length;
                    longest = array[i];
                }
            }

            foreach (var item in array)
            {
                if (item.Length < shortest.Length) {
                    shortest = item;
                    itemShort = item.Length;
                }
            }
                       
            Console.WriteLine($" The longest line is: {longest} and quantity of symbols is: {itemLong}");
            Console.WriteLine($" The shortest line is: {shortest} and quantity of symbols is: {itemShort}");
        }
        
    }
}
