using System;

class RPS {
  static void Main() {
    // player value
    string playerName = "Test player";
    int playerScore = 0;
    string playerChoice = "";

    // CPU VARIABLES
    int cpuScore = 0;
    string cpuChoice = "";

    Console.WriteLine(" hello, i am your friendly Rock paper scissors bot!\n");
    Console.WriteLine("Please tell me your name.\n");
    playerName = console.ReadLine();
    Console.WriteLine("Hey there {playerName}. is this you name?\n");
    Console.WriteLine("please type yes or no, then press enter.\n");
    string isCorrect = console.ReadLine().Tolower();

    if (isCorrect == "yes")
    {
      Console.WriteLine("Great! i'll call you {player name}.\n");
    }
    else if (isCorrect = "no")
    {
      Console.WriteLine("Please restate your name and press enter. \n");
    }
    else
    {
      Console.WriteLine("unable to register answer. \n");
    }

    Console.WriteLine("""
 +===========================================================+ 
 | |
 | WELCOME TO THE ROCK, PAPER, SCISSORS CHALLENGE! |
 +===========================================================+
 You will select from Rock, Paper, or Scissors. 
 The CPU will select one of those choices at random. 
 Then a winner will be determined using the following rules:
 -- Rock Beats Scissors
 -- Paper Beats Rock 
 -- Scissors Beats Paper 

 The winner will receive a point. 
 The first player to score 5 points will be declared the winner.
 """);




 while (playerScore < 5 && cpuScore < 5)
 {
  // print score
  Console.WriteLine("Your score is:{playerScore}\n {cpuScore}\n");

  // allow selection 
  Console.WriteLine("Choose rock, paper, or scissors, type your answer and press enter.\n");

  playerChoice = console.ReadLine().Tolower();
 }

 // allow cpu to select randomly
 random rnd = new random();
 int cpuRand = rnd.Next(0,2);



 if (cpurand == 0)
 {
  cpuChoice = "rock";
 }
 else if (cpuRand == 1)
  {
    cpuChoice = "paper";
  }
  else if (cpu cpuRand == 2)
  {
    cpuChoice = "scissors"
  }
  else
  {
    Console.WriteLine ("unable to determine CPU choice.\n");
  }
  Console.WriteLine("CPU Choice" + cpuChoice);

  //Compare the two choices and find winner
  if (playerChoice == "rock" && cpuChoice == "paper")
  {
    Console.WriteLine("YOU chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("The CPU WINS!!!\n");
    cpuscore++;
  }
  else if (playerChoice == "rock" && cpuChoice == "scissors")
  {
    Console.WriteLine("YOU chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("YoU WIN!!!\n");
    playerScore++;

  }
  else if(playerChoice == "rock" && cpuChoice == "rock")
  {
    Console.WriteLine("You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("It's a draw!");

  }
  else if (playerChoice == "paper" && cpuChoice == "paper")
  {
    Console.WriteLine("You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("It's a draw!");

  }
  else if (playerChoice == "paper" && cpuChoice == "scissors")
  {
    Console.WriteLine("You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("The CPU wins.\n");
    cpuScore ++;

  }
  else if (playerChoice == "paper" && cpuChoice == "rock")
  {
    Console.WriteLine("You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("You win!\n");
    playerScore++;
  }
  else if (playerChoice == "scissors" && cpuChoice "paper")
  {
    Console.WriteLine("You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("You win!\n");
    playerScore++;
  }
  else if (playerChoice == "scissors" && cpuChoice == "scissors")
  {
    Console.WriteLine("You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("It's a draw!"); 
  }
  else if (playerChoice == "scissors" && cpuChoice == "rock")
  {
    Console.WriteLine("You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
    Console.WriteLine("The CPU wins.\n");
    cpuScore++;
  }
  if (playerScore > cpuScore)
  {
    Console.WriteLine("Congratulations, you are the winner!\n"); 
  }
  else
  {
    Console.WriteLine("The CPU has defeated you.\n");
  }
 }
}