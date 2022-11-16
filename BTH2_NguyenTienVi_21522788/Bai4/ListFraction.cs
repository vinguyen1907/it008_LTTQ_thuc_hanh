using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class ListFraction
    {
        private List<Fraction> List;
        private int Amount;

        public ListFraction()
        {
            List = new List<Fraction>();
        }

        public void Input()
        {
            Console.Write("Enter amount of array's elements: ");
            Amount = int.Parse(Console.ReadLine());

            for (int i = 0; i < Amount; i++)
            {
                Console.Write($"Enter numerator of fraction {i + 1}: ");
                int num = int.Parse(Console.ReadLine());
                Console.Write($"Enter denominator of fraction {i + 1}: ");
                int den = int.Parse(Console.ReadLine());

                Fraction temp = new Fraction(num, den);
                List.Add(temp);
            }
        }
        public void Output()
        {
            for (int i = 0; i < List.Count; i++)
            {
                List[i].Output();
                Console.Write(" ");
            }
        }
        public Fraction MaxFraction()
        {
            Fraction maxFraction = List[0];
            double maxValue = List[0].GetValue();
            for (int i = 1; i < List.Count; i++)
            {
                if (List[i].GetValue() > maxValue)
                {
                    maxFraction = List[i];
                }
            }
            return maxFraction;
        }
        public void SortAscending()
        {
            for (int i = 0; i < List.Count - 1; i++)
            {
                if (List[i] > List[i + 1])
                {
                    (List[i], List[i + 1]) = (List[i + 1], List[i]);
                }
            }
        }
    }
}
