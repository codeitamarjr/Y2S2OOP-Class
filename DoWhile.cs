using System;
namespace Y2S2OOP_Class
{
    public class DoWhile
    {
        public static void runDoWhile()
        {
            int value = 5;
            do
            {
                Console.WriteLine("Hello");
            } while (value != 5);


            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(j);
                }
                Console.Write(" ");
            }
        }
    }
}
