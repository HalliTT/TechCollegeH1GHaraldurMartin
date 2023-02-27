using System;

namespace Lommeregner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to minus or 2 to multiple ");
            string menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    Console.WriteLine("MINUS");
                    Console.WriteLine("Write first number");
                    string numberMinusOne = Console.ReadLine();
                    Console.WriteLine("Write second number");
                    string numberMinusTwo = Console.ReadLine();

                    //Transform string to int
                    int numberMinusOneInt = Int32.Parse(numberMinusOne);
                    int numberMinusTwoInt = Int32.Parse(numberMinusTwo);

                    //calculation
                    int minus = numberMinusOneInt - numberMinusTwoInt;

                    //Write out reulst
                    Console.WriteLine(numberMinusOneInt + "-" + numberMinusTwoInt + " = " + minus);
                    break;
                case "2":
                    Console.WriteLine("MULTIPLE");
                    Console.WriteLine("Write first number");
                    string numberMultiOne = Console.ReadLine();
                    Console.WriteLine("Write second number");
                    string numberMultiTwo = Console.ReadLine();
                    
                    //Transform string to int
                    int numberMultiOneInt = Int32.Parse(numberMultiOne);
                    int numberMultiTwoInt = Int32.Parse(numberMultiTwo);

                    //calculation
                    int multi = numberMultiOneInt * numberMultiTwoInt;

                    //Write out reulst
                    Console.WriteLine(numberMultiOneInt + "*" + numberMultiTwoInt + " = " + multi);
                    break;
                default:
                    Console.WriteLine("Sorry try agian");
                    break;
            }
        }
    }
}
