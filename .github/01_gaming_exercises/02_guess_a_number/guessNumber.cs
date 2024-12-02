// Guess a number, Goodwine jermya, 9/6/24 v0.00
using System;
class GuessNumber {
  static void Main() {
    int NumGuess = 0;
    int MaxGuess = 6;
    int guess ;

  // Generates the secret number here.
  Random rnd = new Random(); // create an object name "rnd" that is a copy of the Random()
  int secretNumber = rnd.Next(100); // generate from 0 to 99
  // Console.WriteLine(secretNumber);
  // int secretNumber = rnd.Next(23, 200); // generate from 25 to 199

  // while loop
  while (NumGuess < MaxGuess)
  {
    Console.WriteLine ("secretNumber: " + secretNumber);
    Console.WriteLine("Please guess an integer between 0 and 99.\n");
    guess = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Guess"+ guess);
    // Console.WriteLine(guess);
    NumGuess++;
    if (guess < secretNumber)
    {
      Console.WriteLine("your guess is too low.\n");
    }
    else if (guess > secretNumber)
    {
      Console.WriteLine("your guess is too high! \n");
    }
    else
    {
      Console.WriteLine("You guessed correctly. \n");
      break;
    }
    if (NumGuess >= MaxGuess)
    Console.WriteLine("you have lost the game. \n you suckkkkk. \n")
  }

     // Allow them to guess a number
     // Compare the guess to the secret number.
     // If match, print win, if > or <, give a hint.
     // =1 to the numGuess
     // Check if the numGuess > MaxGuess
     // if true, print a "lose game" message, if false guess again.
  }
}