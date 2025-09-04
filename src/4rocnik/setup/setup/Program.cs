using System;

namespace setup
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Kalkulacka kalkulacka = new Kalkulacka();
            while (true)
            {
                Console.WriteLine("Zadej priklad");
                Console.WriteLine(kalkulacka.CalculateEquation(Console.ReadLine()));
            }
        }
        
    }
}