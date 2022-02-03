using System;
namespace Y2S2OOP_Class
{
    public class ConditionalQ1
    {

//          1. Write a console-based application that prompts a user for an hourly pay rate.While the user
//          enters values less than $5.65 or greater than $49.99, continue to prompt the user. Before the
//          program ends, display the valid pay rate.

        public static void runConditionalQ1()
        {
            Console.WriteLine("What's the hourly pay rate?");
            double payRate = double.Parse(Console.ReadLine());
            while(payRate < 5.65 || payRate > 49.99)
            {
                Console.WriteLine("Try again\nWhat's the hourly pay rate?");
                payRate = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("The hourly pay rate is ${0}", payRate);

        }

    }
}
