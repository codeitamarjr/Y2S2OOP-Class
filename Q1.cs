using System;
namespace Y2S2OOP_Class
{
    public class Q1
    {

        //Exercise 1:
        /*
         * Build a simple calculator. 
         * Read in two integers from the user 
         * and add them together. 
         * subtract
         * multiply
         * division(display quotient and remainder separately)
         * Print the results in a nice output statement.
         * 
         * 
         * */
        public static void runQ1()
        {
            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondNumber = int.Parse(Console.ReadLine());
            //Just to show the answer in another way
            String[] sign = new String[4] { "+", "-", "*", "/" };
            for (int i=0; i < sign.Length; i++)
            {
                int result=0;
                switch (sign[i])
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "/":
                        result = firstNumber / secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                }
                Console.WriteLine("{0} {1} {2} = {3}", firstNumber, sign[i], secondNumber,result);
            }
        }
    }
}
