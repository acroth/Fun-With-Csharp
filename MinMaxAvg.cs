using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MinMaxAvg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number");
            string number1 = Console.ReadLine();
            Console.WriteLine("Please type another");
            string number2 = Console.ReadLine();
            Console.WriteLine("Another number");
            string number3 = Console.ReadLine();
            Console.WriteLine("Another number");
            string number4 = Console.ReadLine();
            Console.WriteLine("One last time");
            string number5 = Console.ReadLine();


            int number1Int = int.Parse(number1);
            int number2Int = int.Parse(number2);
            int number3Int = int.Parse(number3);
            int number4Int = int.Parse(number4);
            int number5Int = int.Parse(number5);
            int average = (number1Int + number2Int + number3Int + number4Int + number5Int);
            int[] numbers = { number1Int, number2Int, number3Int, number4Int, number5Int };
            Array.Sort(numbers);

            Console.WriteLine("The highest number is {0}, the lowest number is {1} \n and the average of those numbers is "
                + average, numbers[4], numbers[0]);



        }
    }
}
