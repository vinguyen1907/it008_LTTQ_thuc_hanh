using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Matrix
    {
        private int[,] matrix;
        private int AmountOfRow;
        private int AmountOfColumn;

        public Matrix(int[,]? matrix, int amountOfRow = 0, int amountOfColumn = 0)
        {
            if (matrix is not null)
            {
                this.matrix = matrix;
            }
            this.AmountOfRow = amountOfRow;
            this.AmountOfColumn = amountOfColumn;
        }
        public void Input()
        {
            Console.Write("Enter amount of rows: ");
            AmountOfRow = int.Parse(Console.ReadLine());
            Console.Write("Enter amount of column: ");
            AmountOfColumn = int.Parse(Console.ReadLine());

            matrix = new int[AmountOfRow, AmountOfColumn];

            for (int i = 0; i < AmountOfRow; i++)
            {
                for (int j = 0; j < AmountOfColumn; j++)
                {
                    Console.Write($"matrix[{i}, {j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Output()
        {
            for (int i = 0; i < AmountOfRow; i++)
            {
                for (int j = 0; j < AmountOfColumn; j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        public void FindElement(int x)
        {
            for (int i = 0; i < AmountOfRow; i++)
            {
                for (int j = 0; j < AmountOfColumn; j++)
                {
                    if (matrix[i, j] == x)
                    {
                        Console.Write($"{matrix[i, j]}*  ");
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + "  ");
                    }
                }
                Console.WriteLine();
            }
        }
        public static bool IsPrimeNumber(int x)
        {
            if (x < 2)
            {
                return false;
            }
            if (x == 2)
            {
                return true;
            }
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void OutputPrimeNumber()
        {
            Console.Write("Prime number: ");
            for (int i = 0; i < AmountOfRow; i++)
            {
                for (int j = 0; j < AmountOfColumn; j++)
                {
                    if (IsPrimeNumber(matrix[i, j]))
                    {
                        Console.Write($"{matrix[i, j]}  ");
                    }
                }
            }
            Console.WriteLine();
        }
        public void FindRowHavingMostPrimeNumber()
        {
            int max = 0;
            int row = 0;
            for (int i = 0; i < AmountOfRow; i++)
            {
                int count = 0;
                for (int j = 0; j < AmountOfColumn; j++)
                {
                    if (IsPrimeNumber(matrix[i, j]))
                    {
                        count++;
                    }
                }
                if (count > max)
                {
                    max = count;
                    row = i;
                }
            }
            Console.WriteLine("The row having the most prime numbers is: " + row);
        }
    }
}
