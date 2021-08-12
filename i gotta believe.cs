using System;

namespace IDFK
{
  class Program
  {
    static void Main(string[] args)
    {
      //Main variables that don't matter but do matter aaa shut UP
      string correctAnswer = "I gotta believe!";
       int lives = 3;
       bool outOfLives = false;
       int score = 0;
       string playerAnswer = "null";
   //Asks the user for input
    Console.Write("You gotta do what?: ");
    playerAnswer = Console.ReadLine();
    //Compares the user's input and checks if it matches with correctAnswer
    if (playerAnswer == correctAnswer)
  {
    //If it matches, it adds one point to the user's score
 score++;
  Console.Write($"You gotta believe!\nYour score is now {score}!");
  }
  else
   {
     //If it doesn't, it removes one life.
     lives--;
     
      Console.WriteLine($"Incorrect! You lost a life!\nYou have {lives} lives left");
    Console.WriteLine($"Your score is {score}");
    }
    
    }
    
    }
    
    
    
   
  }

