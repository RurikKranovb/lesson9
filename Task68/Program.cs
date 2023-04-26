using System;

namespace Task68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число M: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            PritnAckermannFunction(m, n);
        }

        private static void PritnAckermannFunction(int m, int n)
        {
            Console.Write(GetAckermann(m, n));
        }

        static int GetAckermann(int m, int n)
        {
            if (m == 0)
                return n + 1;

            if (n == 0 && m > 0)
                return GetAckermann(m - 1, 1);


            return (GetAckermann(m - 1, GetAckermann(m, n - 1)));
        }
    }
}
