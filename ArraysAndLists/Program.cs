using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            int[] myIntList = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evens = new int[] {2,4,6,8,10};
            var odds = new int[] { 1, 3, 5, 7, 9 };

            

            Console.WriteLine("Enter a number between 1-10");

            
            int num = Convert.ToInt32(Console.ReadLine());


            if (num % 2 == 0)
                
                Console.WriteLine("is even");

            else
                
                Console.WriteLine("is odd");

            
            Console.WriteLine("List of Evens");

            foreach (int i in evens)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("List of Odds");

           foreach (int i in odds) 
            {
            Console.WriteLine(i); 

            }

        
        }
    }
}
