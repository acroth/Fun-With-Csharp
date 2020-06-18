using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Pear", "Apple", "Cherry", "Orange" };
            Console.WriteLine();

            bool fruitRemains = true;

            while (fruitRemains)
            {
                Console.WriteLine("would you like some fruit? write P for for Pear, A for Apple C for Cherry or O for orange");
                ConsoleKey answer = Console.ReadKey().Key;

                switch (answer)
                {
                    case ConsoleKey.P:
                        Console.WriteLine($" here is a {fruits[0]}");
                        break;

                    case ConsoleKey.A:
                        Console.WriteLine($" here is a {fruits[1]}");
                        break;

                    case ConsoleKey.C:
                        Console.WriteLine($" here is a {fruits[2]}");
                        break;

                    case ConsoleKey.O:
                        Console.WriteLine($" here is a {fruits[3]}");
                        break;


                    default: Console.WriteLine(" No fruits for you");
                        break;  
                }


            }//end while

            
            
   
            

        }//end Main
    }//end class
}//end namespace
