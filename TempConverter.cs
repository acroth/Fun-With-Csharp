using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.WriteLine("Give me a temperature in Celcius and i will convert it into Farenheit");
            string celcius = Console.ReadLine();
            int celciusFinal = int.Parse(celcius);
            int farenheit = celciusFinal * 9 / 5 + 32;
            Console.WriteLine(celcius + " degrees celcius, is " + farenheit + " degrees farenheit");



        }

    }
}
