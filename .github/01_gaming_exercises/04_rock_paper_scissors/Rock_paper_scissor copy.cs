using System;
class RPS {
  static void Main() {
    // PLAYER VARIABLE
    int playerScore = 0;
    string playerChoice = "";
    int numDraws = 0;

    // CPU VARIABLES
    int cpuScore = 0;
    string cpuChoice = "";
    


    // TESTING GAME LOOP
    int loopCount = 0;
    int loopReqs = 0;
    Console.WriteLine("How many loops do you need?\nType an INTEGER and press ENTER.");
    loopReqs = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("  ");
    Random rnd = new Random();
    while (loopCount < loopReqs)
    {
      // ALLOW CPU to select randomly.
      int cpuRand = rnd.Next(0,3);

      if (cpuRand == 0)
      {
        cpuChoice = "rock";
      }
      else if (cpuRand == 1)
      {
        cpuChoice = "paper";
      }
      else if (cpuRand == 2)
      {
        cpuChoice = "scissor";
      }
      else
      {
        Console.WriteLine("Unable to determine cpu choice.\n");
      }

      // COMPARE THE TWO CHOICES AND DETERMINE A WINNER.
      if (playerChoice == "rock" && cpuChoice == "paper")
      {
        cpuScore++;
      }
      else if (playerChoice == "rock" && cpuChoice == "scissor")
      {
        playerScore++;
      }
      else if (playerChoice == "rock" && cpuChoice == "rock")
      {
        numDraws++;
      }
      else if (playerChoice == "paper" && cpuChoice == "paper")
      {
        numDraws++;
      }
      else if (playerChoice == "paper" && cpuChoice == "scissor")
      {
        cpuScore++;
      }
      else if (playerChoice == "paper" && cpuChoice == "rock")
      {
        playerScore++;
      }
      else if (playerChoice == "scissor" && cpuChoice == "scissor")
      {
        numDraws++;
      }
      else if (playerChoice == "scissor" && cpuChoice == "paper")
      {
        playerScore++;
      }
      else if (playerChoice == "scissor" && cpuChoice == "rock")
      {
        cpuScore++;
      }
      loopCount++;
    }
    if (playerScore > cpuScore)
    {
      Console.WriteLine("Congrats, you beat the bot!!!");
    }
    else
    {
      Console.WriteLine("The cpu beat you bud, better luck nxt time. ;(.");
    }
    Console.WriteLine($"Player score: {playerScore}\n");
    Console.WriteLine($"Cpu Score: {cpuScore}\n");
    Console.WriteLine($"Draws: {numDraws}\n");
    
  } // DO NOT DELETE THIS EVER!! 3 spaces indented from the left.
} // DO NOT DELETE THID EVER, ALWASY TOUCHING LEFT MARGIN.