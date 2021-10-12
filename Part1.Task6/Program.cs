using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array6 = new int[20];
            Random rndArray6 = new Random();
            
            for (int i = 0; i < array6.Length; i++)
            {
                array6[i] = rndArray6.Next(-10, 10);
            }

            foreach (var item in array6)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var dict = new Dictionary<int, int>();

            foreach (var value in array6)
            {
                // When the key is not found, "count" will be initialized to 0
                dict.TryGetValue(value, out int count);
                dict[value] = count + 1;
            }

            foreach (var pair in dict)
                if (pair.Value > 1)
                {
                   Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
                }
            Console.ReadLine();
        }
    }
}
