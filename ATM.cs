using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to Roth Trust ATM please enter your account number");
            int userAccount = int.Parse(Console.ReadLine());


            if (userAccount == 1234567)
            {
                Console.WriteLine("Access granted");
                
            }//end if
            else 
                {
                    Console.WriteLine("Access Denied");
                }//end if

            
            if (userAccount== 1234567)
            {
                Console.WriteLine("Please enter your pin number");
                int pinNumber = int.Parse(Console.ReadLine());

                if (pinNumber == 6389)

                {
                    Console.WriteLine("Access Granted");
                    if (pinNumber != 6389)
                    {
                        Console.WriteLine("Access Denied");
                    }
                }//end if
            }//end else if
            bool repeat = true;
            do
            {
                Console.WriteLine("Would you like to:\n"+
                    "D) Make a Deposit?\n"+
                    "W) Make a withdraw?\n" +
                    "E) Exit");
                ConsoleKey userChoice = Console.ReadKey(true).Key;
                Console.Clear();

                switch (userChoice)
                {
                    case ConsoleKey.D:
                        Console.WriteLine("how much would you like to deposit?");
                        decimal deposit = decimal.Parse(Console.ReadLine());
                        Console.WriteLine(" You have deposited {0:c}, into account 1234567",deposit);
                        break;
                    case ConsoleKey.W:
                        Console.WriteLine("how much would you like to withdraw?");
                        decimal withdraw = decimal.Parse(Console.ReadLine());
                        Console.WriteLine(" You have withdrawn {0:c}, from account 1234567",withdraw);
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("Thank you for choosing Roth Trust");
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("invalid request, $30 fee has been assessed");
                        break;
                }
            } while (repeat);


        }//end main
    }//end class
}//end namespace
