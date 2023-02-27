using System;

namespace Lommeregner
{
    class Program
    {
        double tal1;
        double tal2;
        double resultat;
        static void Main(string[] args)
        {
            Console.WriteLine("Tal 1");
            double tal1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("tal 2");
            double tal2 = Convert.ToDouble(Console.ReadLine());
            double resultat = tal1 + tal2;
            Console.Writeline("resultat er");
            Console.WriteLine(resultat);
        }
    }
}
