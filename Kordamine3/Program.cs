using System;

namespace Kordamine3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int mult = 1;
            int sum = 0;
            for (int i = 0; 1 < 5, i++)
            {
                Console.Write("Please enter your number; ");
                int set = Convert.ToInt32(Console.ReadLine());
                sum += set;
                mult = set + mult;
            }
            double avg = sum / 5;
            Console.WriteLine($"Nums AVG = (avg)\")*/

            string w;

            do
            {

                Console.WriteLine("Osta elevant!!!");
                w = Console.ReadLine();

            } while (w != "elevant");

            if (w == "elevant")
            {
                Console.WriteLine("Väga hästi! Head aega!");
            }

        }
    }
}
