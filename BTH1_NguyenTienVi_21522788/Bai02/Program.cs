using System;

namespace MyApp
{
    class Program
    {
        static bool isPrimeNumber(int a)
        {
            if (a < 2)
            {
                return false;
            }
            if (a == 2)
            {
                return true;
            }
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(String[] args) 
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                if (isPrimeNumber(i))
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}