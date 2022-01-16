using System;

namespace ex3
{
    class Program3
    {
        static void Public(string[] args)
        {
            Console.WriteLine("Введите любое натуральное число, не превышающее 1000");
            int N = Convert.ToInt32(Console.ReadLine());
            int S = 0;
            Console.WriteLine(N % 10);
            while (N != 0)
            {
                S += (N % 10);
                N /= 10;
            }
            Console.WriteLine(S);
        }
    }
}