using System;
namespace Y2S2OOP_Class
{
    public class LoopQ3
    {

        //2. Write a console-based application that sums the integers from 1 to 50.
        public static void runLoopQ3()
        {
            int sum = 0;
            for(int i = 0; i < 50; i++)
            {
                sum++;
            }
            Console.WriteLine("The sums of integers from 1 to 50 is {0}", sum);
        }
    }
}
