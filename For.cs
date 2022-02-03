using System;
namespace Y2S2OOP_Class
{
    public class For
    {

        //Lecture 25: For Loops
        public static void runFor()
        {
            int x = 0;
            while (x < 5)
            {
                Console.WriteLine("Hello");
                Console.ReadLine();
                x++;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("hellooooooo");
                Console.ReadLine();
            }


            //for (; ; )
            //{
            //    Console.WriteLine("hellooooooo");
            //    Console.ReadLine();
            //}

            Console.WriteLine("Enter an amount of times to print Week2");
            int amount = int.Parse(Console.ReadLine());

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Week2");
                Console.ReadLine();

            }
        }
    }
}
