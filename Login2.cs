using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your User Name");
            string userName = Console.ReadLine();
            switch (userName)
            {
                case "user123":
                    Console.WriteLine("access granted");
                    break;


                default:
                    Console.WriteLine("Access Denied");
                    break;
            }

        }//end main
    }//end class
}//end namespace
