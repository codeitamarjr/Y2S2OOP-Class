using System;
namespace Y2S2OOP_Class
{
    public class Q2
    {
        //Exercise 2
        /*
         * Write a program that asks the user for the length and width of their room. Define a constant
         * that represents the price of carpeting per square foot. Compute and display the cost of carpeting the room.
         * 
         * */
        public static void runQ2()
        {
            const double per_square_foot = 10.50;

            Console.WriteLine("Enter the length of your room");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of your room");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double price = area * per_square_foot;

            Console.WriteLine("The cost to carpet this {0} by {1} room is ${2}", length, width, price);
            Console.ReadLine();

        }
    }
}
