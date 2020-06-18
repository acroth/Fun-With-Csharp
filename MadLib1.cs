using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib1
    {
        static void Main(string[] args)
        {
            Console.Title = "~~~~MaDLiB~~~~";
            Console.WriteLine();
            Console.WriteLine("Letter to the Father");
            Console.WriteLine();
            Console.WriteLine("When please input the info requested below to complete this Mad Lib!");
            Console.WriteLine();
            Console.WriteLine("Man's Name");
            string mansName = Console.ReadLine();
            Console.WriteLine("Adjective");
            string adjective = Console.ReadLine();
            Console.WriteLine("Girls Name");
            string girlsName = Console.ReadLine();
            Console.WriteLine("Noun");
            string noun = Console.ReadLine();
            Console.WriteLine("Noun");
            string noun2 = Console.ReadLine();
            Console.WriteLine("Noun");
            string noun3 = Console.ReadLine();
            Console.WriteLine("Plural Noun");
            string pluralNoun = Console.ReadLine();
            Console.WriteLine("Noun");
            string noun4 = Console.ReadLine();
            Console.WriteLine("Adjective");
            string adjective2 = Console.ReadLine();
            Console.WriteLine("Number");
            string number = Console.ReadLine();
            Console.WriteLine("Noun");
            string noun5 = Console.ReadLine();
            Console.WriteLine("Geographical Location");
            string location = Console.ReadLine();
            Console.WriteLine("Adjective");
            string adjective3 = Console.ReadLine();
            Console.WriteLine("Adjective");
            string adjective4 = Console.ReadLine();
            Console.WriteLine("Noun");
            string noun6 = Console.ReadLine();
            Console.WriteLine("Your Name");
            string yourName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Dear {0},\n I am in love with your {1} daughter, {2}\nand would like to ask her"+
                "{3} in marriage. She is my idea of a perfect {4}.\nShe is the only {5} I have ever loved" +
                "\nand I want her to be the mother of my {6}. At present, I am employed as an assistant {7}" +
                "\nand I make a {8} salary of {9} dollars a week. I have a split level {10} picked out in {11} "+
                "\nthat we can live in. If you give me your permission i promise to make her {12} and to be a {13} {14}"+
                "\nsigned {15}", mansName, adjective, girlsName, noun, noun2, noun3, pluralNoun, noun4, adjective2,
                number, noun5, location, adjective3, adjective4, noun6, yourName );
        



















        }
    }
}
