using System;
namespace Y2S2OOP_Class
{
    public class CreatingMethods
    {
        public static void runCreatingMethods()
        {
            //Creating Methods
            static void run()
            {
                int answer = Add(5, 10);
                int secondAnswer = Add(answer, 5);
                Console.WriteLine(secondAnswer);

            }

        }
        public static int Add(int number1, int number2)
        {
            int answer = number1 + number2;
            return answer;
        }


    }
}
