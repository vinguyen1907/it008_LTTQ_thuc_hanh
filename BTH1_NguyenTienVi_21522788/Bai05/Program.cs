
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

        static void weekdayOfDate(int day, int month, int year)
        {
            if (!isValidDate(day, month, year))
            {
                Console.WriteLine("Ngay khong hop le!!!");
            }
            else
            {
                // Zeller's formula
                year -= (14 - month) / 12;
                month += 12 * ((14 - month) / 12) - 2;
                int dayMax = (day + year + year / 4 - year / 100 + year / 400 + (31 * month) / 12) % 7;
                if (dayMax == 0)
                {
                    Console.WriteLine("Chu nhat") ;
                }else
                {
                    Console.WriteLine("Thu " + (dayMax + 1));
                }
            }
        }

        static void Main(String[] args)
        {
            Console.Write("Nhap ngay: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            int year = int.Parse(Console.ReadLine());
            weekdayOfDate(day, month, year);
        }
    }
}