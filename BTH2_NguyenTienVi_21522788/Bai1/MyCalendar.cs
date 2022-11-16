using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Bai1
{
    class MyCalendar
    {
        private int Month;
        private int Year;

        public MyCalendar(int month = 0, int year = 0)
        {
            Month = month;
            Year = year;
        }
        public void Input()
        {
            Console.Write("Enter month: ");
            Month = int.Parse(Console.ReadLine());
            Console.Write("Enter year: ");
            Year = int.Parse(Console.ReadLine());
        }
        public static string AddSpace(string day)
        {
            if (day.Length == 1)
            {
                day = "  " + day + "  ";
            }
            else if (day.Length == 2)
            {
                day = " " + day + "  ";
            }
            return day;
        }
        public void Display()
        {
            DateTime myDT = new DateTime(Year, Month, 1, new GregorianCalendar());
            Calendar myCal = CultureInfo.InvariantCulture.Calendar;

            int firstDayOfWeek = 0;

            switch (myCal.GetDayOfWeek(myDT))
            {
                case DayOfWeek.Monday:
                    firstDayOfWeek = 0;
                    break;
                case DayOfWeek.Tuesday:
                    firstDayOfWeek = 1;
                    break;
                case DayOfWeek.Wednesday:
                    firstDayOfWeek = 2;
                    break;
                case DayOfWeek.Thursday:
                    firstDayOfWeek = 3;
                    break;
                case DayOfWeek.Friday:
                    firstDayOfWeek = 4;
                    break;
                case DayOfWeek.Saturday:
                    firstDayOfWeek = 5;
                    break;
                case DayOfWeek.Sunday:
                    firstDayOfWeek = 6;
                    break;
            }

            int day = 1;

            Console.WriteLine(" Mon  Tue  Wed  Thu  Fri  Sat  Sun ");

            // in hang dau 
            for (int i = 0; i < 7; i++)
            {
                if (i < firstDayOfWeek)
                {
                    Console.Write("     ");
                }
                else
                {
                    Console.Write(AddSpace(day.ToString()));
                    day++;
                }
            }
            Console.WriteLine();

            // in cac dong con lai
            while (day <= myCal.GetDaysInMonth(Year, Month))
            {
                for (int i = 0; i < 7; i++)
                {
                    if (day <= myCal.GetDaysInMonth(Year, Month))
                    {
                        Console.Write(AddSpace(day.ToString()));
                        day++;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
