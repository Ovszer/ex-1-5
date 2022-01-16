using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырёхзначное число");
            int N = Convert.ToInt32(Console.ReadLine());
            int N1 = (N / 1000);
            int N2 = (N / 100 % 10);
            int N3 = (N / 10 % 10);
            int N4 = (N % 10);
            int S = (N1 + N2) - (N3 + N4);
            if (S == 0)
            {
                Console.WriteLine(1);
            }
            else {
                Console.WriteLine(S);
        }
        }
    }
}
