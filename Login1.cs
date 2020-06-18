using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login1
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Enter your username:");
            string userName = Console.ReadLine().ToLower();

            
            if (userName == "user123")
            {
               
                Console.WriteLine("access granted");

            }// end if
            else if (userName != "user123")
            {
                Console.WriteLine("access denied");
            }//end else if



        }//end main
    }//end class
}//end namespace
