using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an if decision block
            //use this if block to chec for an even number

            //Request user input with ReadLine()
            Console.WriteLine("Please enter an integer value and press Enter.");

            //Assign the ebtered vakye ti tge variable input
            //convert input to integer before using
            int input = Int32.Parse(Console.ReadLine());

            /// Check to see if the number is even.
            // Here we use the simple task of checking for a remainder when dividing by 2
            // The (%) or modulus operator returns the remainder of integer devision.
            // If the remainder is 0, then the value is able to be divided by 2 with
            // no remainder, which means it is an even number.
            if(input % 2 ==0)
            {
                Console.WriteLine("The number entered was an even number");
            }
            else //the remainder was not 0 so the value entered is an odd number
            {
                Console.WriteLine("The number entered was not an even number");
            }
        }
    }
}
