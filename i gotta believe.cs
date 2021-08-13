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
            string answer = "I gotta believe!";
            bool outOfLives = false;
            string playerAnswer = ""; 
            int guessCount = 0;       
            //Asks the user for input and compares it
            
            while(playerAnswer != answer && !outOfLives)
            {
              if(guessCount < lives)
              {
                Console.Write("You gotta do what?: ");
            playerAnswer = Console.ReadLine();
             guessCount++;            
              }
              else 
              {
                outOfLives = true;
              }
              
              
            }
            if(outOfLives)
            {
              Console.WriteLine($"You lost! \nYour score is {score}");
              Console.WriteLine("To try again, type Retry.");
              if(Console.ReadLine() == "Retry")
              {
                //Resets everything.
                outOfLives = false;
                guessCount = 0;
                playerAnswer = "";
              }
                            
              
            } 
            else
             {
             Console.Write($"You gotta believe!\nYour score is now {++score}!");
           
              }         
        }
    } 
}
