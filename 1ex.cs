using System;

namespace ex1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во белок (не превышает 1000)");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во орехов (не превышает 1000)");
            int K = Convert.ToInt32(Console.ReadLine());
            int C = K / N;
            Console.WriteLine(C);
        }
    }
}