using System;
namespace Y2S2OOP_Class
{
    public class While
    {

        //lecture 24: While Loops
        //Program that keeps a running total of numbers
        //Example of indefinite loop - depends on the user
        public static void runWhile()
        {
            int runningTotal = 0;
            // variable that store the sum of the total user input integers

            Console.WriteLine("Enter a number, or -1 to quit");
            int number = int.Parse(Console.ReadLine());

            while (number != -1)
            {
                runningTotal += number;
                // Ask the user over and over again to enter a number or -1 to continue
                Console.WriteLine("Enter a number, or -1 to quit");
                number = int.Parse(Console.ReadLine());
            }
            //here this is break point
            Console.WriteLine("The total is {0}", runningTotal);
            Console.ReadLine();
        }
    }
}
