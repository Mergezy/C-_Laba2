using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X: ");
            int numX = Convert.ToInt16(Console.ReadLine());
            if (numX == 0) { Console.WriteLine("X не может быть равен 0!"); return; }

            Console.Write("N: ");
            int numN = Convert.ToInt16(Console.ReadLine());
            double sum = 0;

            while (numN >= 0) 
            {
                double m =  1 / ((2 * numN + 1) * Math.Pow(numX, 2 * numN + 1));
                sum =+ m;
                numN--;
            }
            sum = sum*2;
            Console.WriteLine($"{sum}");
        }
    }
}
