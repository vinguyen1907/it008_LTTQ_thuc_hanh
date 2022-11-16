using System;
using System.Data;

namespace Bai1
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCalendar Calendar = new();
            Calendar.Input();
            Calendar.Display();
        }
    }
}
