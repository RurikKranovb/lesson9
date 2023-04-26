using System;

namespace Task66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число M:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число N:");
            int n = Convert.ToInt32(Console.ReadLine());

            PrintSumNumber(m, n);

            void PrintSumNumber(int m, int n)
            {
                Console.Write(SumNumbers(m, n) + m);
            }

            int SumNumbers(int m, int n)
            {
                if (m == n) return 0;

                m++;
                var sum = m + SumNumbers(m, n);
                return sum;
            }

        }
    }
}
