using System;
namespace Y2S2OOP_Class
{
    public class RandomQuestionQ3
    {
//      3. Write a program that generates a random number between 1 and 10. Ask a user to guess the
//      random number, then display the random number and a message indicating whether the user's
//      guess was too high, too low, or correct.
//      ------HINT-------
//      You can create a random number that is at least min but less than max using the following
//      statements
//      Random randomGenerator = new Random();
//      int randomNumber = randomGenerator.Next(min, max); 1, 11
        public static void runRandomQuestion()
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);
            Console.WriteLine("Try guess the number?");
            int number = int.Parse(Console.ReadLine());

           if (number > randomNumber) Console.WriteLine("Too high the number is {0}", randomNumber);
           if (number < randomNumber) Console.WriteLine("Too low the number is {0}", randomNumber);
           if (number == randomNumber) Console.WriteLine("Correct the number is {0}", randomNumber);


        }
    }
}
