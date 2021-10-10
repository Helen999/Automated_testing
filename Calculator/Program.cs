using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int result, x, y;
            
            Console.WriteLine("Введите целое число");
            string input = Console.ReadLine();
            x = int.Parse(input);
            Console.WriteLine("Введите целое число");
            string input1 = Console.ReadLine();
            y = int.Parse(input1);

                Console.WriteLine("Введите +,- или /");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        Console.WriteLine("Сумма равна: ");
                        result = x + y;
                        Console.WriteLine($"{result}");
                        break;
                    case "-":
                        Console.WriteLine("Вычитание равно: ");
                        result = x - y; Console.WriteLine($"{result}");
                        break;
                    case "/":
                        while (y == 0)
                        {
                            Console.WriteLine("Введите число не равное 0");
                             y = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Деление равно: ");
                    result = x / y; 
                    Console.WriteLine($"{result}");

                    break;
                    default:
                    break;
                }
        }
    }
}
