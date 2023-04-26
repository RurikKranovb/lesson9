using System;

namespace Task64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение M:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение N:");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintNaturalNumber(n, m);


            static void PrintNaturalNumber(int n, int m)
            {
                if (m > n)
                {
                    return;
                }
                PrintNaturalNumber(n, m + 1);
                Console.Write(m + " ");
            }
        }
    }
}
