
using System;

namespace MyApp
{
    class Program
    {
        static bool isLeapYear(int year)
        {
            return (year % 4 == 0);
        }
        static int numberOfDays(int month, int year)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if (isLeapYear(year))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
            }
            return 30;
        }

        static bool isValidDate(int day, int month, int year)
        {
            if (month < 1 || month > 12)
            {
                return false;
            }
            else if (year < 0)
            {
                return false;
            }
            else if (day < 1 || day > numberOfDays(month, year))
            {
                return false;
            }
            return true;
        }

        static void Main(String[] args)
        {
            Console.WriteLine("Nhap ngay: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine(isValidDate(day, month, year));
        }
    }
}