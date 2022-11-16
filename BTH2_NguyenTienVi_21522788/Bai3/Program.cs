namespace Bai3
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix a = new(null);
            a.Input();
            a.Output();
            Console.Write("Enter value which you want to find: ");
            int x = int.Parse(Console.ReadLine());
            a.FindElement(x);
            a.OutputPrimeNumber();
            a.FindRowHavingMostPrimeNumber();
        }
    }
}