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
            //Save number one as Double
            Console.WriteLine("Write first number");
            double numberOne = Convert.ToDouble(Console.ReadLine());

            //Save number two as Double
            Console.WriteLine("Write second number");
            double numberTwo = Convert.ToDouble(Console.ReadLine());

            //wite out
            Console.WriteLine("------------------");
            Console.WriteLine("Press 1 to add ");
            Console.WriteLine("Press 2 to minus ");
            Console.WriteLine("Press 3 to multiple ");
            Console.WriteLine("Press 4 to divide ");
            Console.WriteLine("------------------");

            //Read what is written and save in variable menu
            string menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    Console.WriteLine("ADD");
                    //calculation add
                    double resultAdd = numberOne + numberTwo;

                    //Write out reulst
                    Console.WriteLine(numberOne + "+" + numberTwo + " = " + resultAdd);
                    break;
                case "2":
                    Console.WriteLine("MINUS");
                    //calculation add
                    double resultMinus = numberOne - numberTwo;

                    //Write out reulst
                    Console.WriteLine(numberOne + "-" + numberTwo + " = " + resultMinus);
                    break;
                case "3":
                    Console.WriteLine("MULTIPLE");
                    //calculation add
                    double resultMultiple = numberOne * numberTwo;

                    //Write out reulst
                    Console.WriteLine(numberOne + "*" + numberTwo + " = " + resultMultiple);
                    break;
                case "4":
                    Console.WriteLine("DIVIDE");
                    //calculation add
                    double resultDivide = numberOne / numberTwo;

                    //Write out reulst
                    Console.WriteLine(numberOne + "/" + numberTwo + " = " + resultDivide);
                    break;
                default:
                    Console.WriteLine("Sorry try agian");
                    break;
            }
        }
    }
}
