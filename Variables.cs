using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Variables
    {
        static void Main(string[] args)
        {

            int number = 27;// begin variables #1
            Console.WriteLine(number);
            char character = '@';
            Console.WriteLine(character);
            string name = "Alina";
            Console.WriteLine(name);
            double smallNmbr = 13;
            Console.WriteLine(smallNmbr);
            float bigNmber = 123;
            Console.WriteLine(bigNmber);
            byte vrySmallNmbr = 1;
            Console.WriteLine(vrySmallNmbr);
            
            //end Variables #1

            Console.WriteLine();

            int[]rndmNumbers = { 36, 24, 47, 182, 50 };

            foreach (int rndmNumber in rndmNumbers)
            {
                Console.WriteLine( rndmNumber);
            }//end foreach int
            Console.WriteLine();

            char[] rndmCharacters = { '*', '&', '-', '/', '~', };
            foreach (char rndmCharacter in rndmCharacters)
            {
                Console.WriteLine(rndmCharacter);
            }//end foreach char
            Console.WriteLine();

            string[] rndmWords = { "jockstrap", "eagle", "snowflake", "koala", "spaceship", };
            foreach (string rndmWord in rndmWords)
            {
                Console.WriteLine(rndmWord);
            }//end foreach string
            Console.WriteLine();

            double[] rndmFractions = { 12.9, 1.2, 9, 1.25, 3.5 };
            foreach (double rndmFraction in rndmFractions)
            {
                Console.WriteLine(rndmFraction);
            }//end foreach double
            Console.WriteLine();

            float[] rndmFractions2 = { 1, 2, 3, 4, 5 };
            foreach (float rndmFraction2 in rndmFractions2)
            {
                Console.WriteLine(rndmFraction2);
            }// end foreach float
            Console.WriteLine();

            byte[] smlNumbers = { 4, 3, 5, 8, 2 };
            foreach (byte smlNumber in smlNumbers)
            {
                Console.WriteLine(smlNumber);
            }// end foreach byte
            Console.WriteLine();

            // end variables # 2

            int number2 = 100;

            while (number2 >= 0)
            {
                Console.WriteLine("counting down: " + number2);
                number2-=2; 
            }// end while countdown

            Console.WriteLine();
            int number3 = 100;
            do
            {
                Console.WriteLine("counting down {0}:", number3);
                number3-=2;
            } while (number3 >= 0);
            //end do while countdown

            Console.WriteLine();
            for (int number4 = 100 ; number4 >= 0; number4 -= 2 )
            {
                Console.WriteLine("counting down {0}",number4);
            }
            //end for countdown


            







        }// end Main()
    }// end class
}//end namespace
