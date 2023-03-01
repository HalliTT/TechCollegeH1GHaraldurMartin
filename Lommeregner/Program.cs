using System;

namespace Lommeregner
{
    class Program
    {
        /// <summary>
        /// Main code is calculator with +, -, * and / function.
        /// <para>
        /// numberOne {double} = First value writen
        /// numberTwo {double} = Second value writen
        /// </para>
        /// <return>
        /// This function does not return anything
        /// </return>
        /// </summary>
        static double numberOne; double numberTwo; void Main(string[] args)
        {
            //Save first number writen in console as Double
            Console.WriteLine("Write first number");
            numberOne = Convert.ToDouble(Console.ReadLine());

            //Save number two as Double
            Console.WriteLine("Write second number");
            numberTwo = Convert.ToDouble(Console.ReadLine());

            
            //wite out Menu
            Console.WriteLine("------------------");
            Console.WriteLine("Press 1 to add ");
            Console.WriteLine("Press 2 to minus ");
            Console.WriteLine("Press 3 to multiple ");
            Console.WriteLine("Press 4 to divide ");
            Console.WriteLine("------------------");

            //Read what is written and save in variable menu
            string menu = Console.ReadLine();
            
            //Depend on what is writen go to that
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
                    //calculation minus
                    double resultMinus = numberOne - numberTwo;

                    //Write out reulst
                    Console.WriteLine(numberOne + "-" + numberTwo + " = " + resultMinus);
                    break;
                case "3":
                    Console.WriteLine("MULTIPLE");
                    //calculation multiple
                    double resultMultiple = numberOne * numberTwo;

                    //Write out reulst
                    Console.WriteLine(numberOne + "*" + numberTwo + " = " + resultMultiple);
                    break;
                case "4":
                    Console.WriteLine("DIVIDE");
                    //calculation divide
                    double resultDivide = numberOne / numberTwo;

                    //Write out reulst
                    Console.WriteLine(numberOne + "/" + numberTwo + " = " + resultDivide);
                    break;
                default:
                    //If non of the above write this
                    Console.WriteLine("Sorry try agian");
                    break;
            }
        }
    }
}
