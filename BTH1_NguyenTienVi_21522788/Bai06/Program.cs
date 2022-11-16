
using System;

namespace MyApp
{
    class Program
    {

        static void initMatrix(int[,] arr, int n, int m)
        {
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = r.Next();
                }
            }
        }
        static void outputMatrix(int[,] arr, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static int maxElementInMatrix(int[,] arr, int n, int m)
        {
            int max = arr[0,0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }
            return max;
        }
        static int minElementInMatrix(int[,] arr, int n, int m)
        {
            int min = arr[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min= arr[i, j];
                    }
                }
            }
            return min;
        }
            
        static int maxLine(int[,] arr, int n, int m)
        {
            int max = int.MinValue;
            int lineIndex = -1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        lineIndex = i;
                    }
                }
            }
            return lineIndex;
        }

        static bool isPrimeNumber(int n)
        {
            if (n < 2)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int sumOfNotPrimeElements(int[,] arr, int n, int m)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (!isPrimeNumber(arr[i,j]))
                    {
                        sum += arr[i,j];
                    }
                }
            }
            return sum;
        }

        static void deleteLine(int[,] arr, ref int n, int m)
        {
            Console.Write("Enter order of line you want to delete: ");
            int line = int.Parse(Console.ReadLine());
            for (int i = line; i < n - 1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = arr[i + 1, j];
                }
            }
            n--;
        }

        static void deleteLineWithMaxElement(int[,] arr,  int n, ref int m)
        {
            // find index of the column have max element
            int max = int.MinValue;
            int columnIndex = -1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        columnIndex = j;
                    }
                }
            }

            // delete the column have max element
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    arr[i, j] = arr[i, j + 1];
                }
            }
            m--;
        }

        static void Main(String[] args)
        {
            Console.Write("Nhap so dong: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int m = int.Parse(Console.ReadLine());

            int[,] arr = new int[n,m];
            initMatrix(arr, n, m);
            outputMatrix(arr, n, m);
        }
    }
}