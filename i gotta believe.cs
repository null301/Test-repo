using System;

namespace IDFK
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main variables that don't matter but do matter aaa shut UP
            int lives = 3;
            int score = 0;
            bool outOfLives = false;
            
            //Asks the user for input
            Console.Write("You gotta do what?: ");
            string playerAnswer = Console.ReadLine();
   
            //Compares the user's input and checks if it matches with correctAnswer
            if (playerAnswer == "I gotta believe!")
                Console.Write($"You gotta believe!\nYour score is now {++score}!");
            else
                Console.WriteLine($"Incorrect! You lost a life!\nYou have {--lives} lives left\nYour score is {score}");
        }
    } 
}
