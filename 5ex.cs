using System;

namespace ex 1-5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите часы, минуты, секунды первого момента времени");
            int H1 = Convert.ToInt32(Console.ReadLine());
            int M1 = Convert.ToInt32(Console.ReadLine());
            int S1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите часы, минуты, секунды второго момента времени");
            int H2 = Convert.ToInt32(Console.ReadLine());
            int M2 = Convert.ToInt32(Console.ReadLine());
            int S2 = Convert.ToInt32(Console.ReadLine());
            int R = (H1 - H2) + ((M1 - M2) * 60) + ((S1 - S2) * 3600)
            Console.WriteLine(R)
        }
    }
}
