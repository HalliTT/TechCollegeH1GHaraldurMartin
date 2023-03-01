using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int addNew = Convert.ToInt32(Console.ReadLine());
            int[] arrayHundred = new int[addNew];


            int[] newArray = new int[10];

            

            for (int i = 0; i < addNew; i++)
            {
                newArray[i] = i;
            }

            //TILFØJ ARRAY 
            for (int i = 0; i < newArray.Length; i++)
            {
                arrayHundred[i] = newArray[i];
            }

            //TILFØJ ARRAY 100
            int index = 0;
            foreach (int v in newArray)
            {
                arrayHundred[index++] = v;
            }

            Console.WriteLine("--------- 10 Array ---------");
            Console.WriteLine();
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i]);
            }
            Console.WriteLine();

            Console.WriteLine("--------- 100 Array ---------");
            Console.WriteLine();

            for (int i = 0; i < arrayHundred.Length; i++)
            {
                Console.Write(arrayHundred[i]);
            }

            //TILFØJ ARRAY 100
            //for (int i = 0; i < newArray.Length; i++)
            //{
            //    arrayHundred[i] = newArray[i];
            //}


            ////Udskriv array 100
            //for (int ii = 0; ii < arrayHundred.Length; ii++)
            //{
            //    Console.WriteLine(arrayHundred[ii]);
            //}


            // ---- TEST ---- //
            //int testInt = 1;
            //int[] arrayHundredNew = new int[testInt];

            //int cons = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < cons; i++)
            //{
            //    if (testInt >= i)
            //    {
            //        testInt++;
            //    }
            //    arrayHundredNew[i] = 2;
            //    if (testInt == 100)
            //    {
            //        return;
            //    }
            //}
            //for (int i = 0; i < arrayHundredNew.Length; i++)
            //{
            //    Console.WriteLine(arrayHundredNew[i]);
            //}

        }
    }
}
