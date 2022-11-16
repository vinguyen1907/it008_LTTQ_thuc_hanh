using System;

    namespace MyApp
{
    class Program
    {
        static int sumOfOddNumbers(int[] arr)
        {
            int sumOfOddNumbers = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    sumOfOddNumbers += arr[i];
                }
            }
            return sumOfOddNumbers;
        }

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

        static int quantityOfPrimeNumber(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (isPrimeNumber(arr[i]))
                {
                    count++;
                }
            }
            return count;
        }

        static bool isSquareNumber(int number)
        {
            int temp = (int)Math.Sqrt(number);
            return temp * temp == number;
        }

        static int minSquareNumber(int[] arr)
        {
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (isSquareNumber(arr[i]) && arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min != int.MaxValue ? min : -1;
        }
        static void Main(String[] args)
        {
            int[] arr = { 2, 3, 4, 5, 6 };

            Console.WriteLine(sumOfOddNumbers(arr));
            Console.WriteLine(quantityOfPrimeNumber(arr));
            Console.WriteLine(minSquareNumber(arr));
        }
    }
}