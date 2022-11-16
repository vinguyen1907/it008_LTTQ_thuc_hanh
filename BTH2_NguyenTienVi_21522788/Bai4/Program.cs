using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new();
            Console.WriteLine("Enter the first fraction: ");
            a.Input();

            Fraction b = new();
            Console.WriteLine("Enter the second fraction: ");
            b.Input();

            Console.Write("Sum: ");
            Fraction.Simplify(a + b).Output();
            Console.WriteLine();

            Console.Write("Substraction: ");
            Fraction.Simplify(a - b).Output();
            Console.WriteLine();

            Console.Write("Mulitplication: ");
            Fraction.Simplify(a * b).Output();
            Console.WriteLine();

            Console.Write("Devision: ");
            Fraction.Simplify(a / b).Output();
            Console.WriteLine();


            ListFraction list = new();
            list.Input();

            Console.Write("The max fraction: ");
            list.MaxFraction().Output();
            Console.WriteLine();

            list.SortAscending();
            Console.Write("Array after sort ascending: ");
            list.Output();

            // prevent auto closing console
            Console.ReadKey();
        }
    }
}
