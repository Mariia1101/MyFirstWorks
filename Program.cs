using System;

namespace MaryLiCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            string sign = (Console.ReadLine());

            switch (sign)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "/":
                        if (b == 0)
                            Console.WriteLine("На 0 делить нельзя!");
                        else
                            Console.WriteLine(a / b);
                        break;
                case "*":
                        if (b == 0)
                            Console.WriteLine("На 0 множить нельзя!");
                        else
                            Console.WriteLine(a * b);
                    break;
                default:
                    Console.WriteLine("Invalid sign!");
                    break;

            }
        }
    }
}
