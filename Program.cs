using System;
using System.Threading;

namespace rockpaperscissors_csharp
{
  class Program
  {
    static void Main(string[] args)
    {

      Boolean done = false;
      int playerScore = 0;
      int compScore = 0;
      int tieGame = 0;
      Console.Clear();
      Console.WriteLine("What is your name?");
      string player = Console.ReadLine();

      Console.WriteLine("Would you like to play Rock Paper Scissors?");
      string start = Console.ReadLine().ToLower();
      if (start == "yes" || start == "y")
      {
        while (done == false)
        {



          Console.WriteLine("Which item do you pick?");
          Console.WriteLine("Rock Paper or Scissors?");
          string selection = Console.ReadLine().ToLower();


          if (selection == "rock")
          {
            int choice = 0;
            Random r = new Random();
            int genRAnd = r.Next(0, 2);
            if (choice == 0 && genRAnd == 2)
            {
              Console.WriteLine("My choice was SCISSORS");
              Console.WriteLine("You Win! Good Job " + player);
              playerScore++;

            }
            else if (choice == genRAnd)
            {
              Console.WriteLine("My choice was ROCK, also");
              Console.WriteLine("We tied!" + player);
              tieGame++;
            }
            else
            {
              Console.WriteLine("My choice was PAPER, I win");
              Console.WriteLine("Better luck next time!" + player);
              compScore++;
            }
          }
          else if (selection == "paper")
          {
            int choice = 1;
            Random r = new Random();
            int genRAnd = r.Next(0, 2);
            if (choice == 1 && genRAnd == 0)
            {
              Console.WriteLine("My choice was ROCK");
              Console.WriteLine("You Win! Good Job " + player);
              playerScore++;
            }
            else if (choice == genRAnd)
            {
              Console.WriteLine("My choice was PAPER, also");
              Console.WriteLine("We tied!" + player);
              tieGame++;
            }
            else
            {
              Console.WriteLine("My choice was SCISSORS, I win");
              Console.WriteLine("Better luck next time!" + player);
              compScore++;
            }

          }
          else if (selection == "scissors")
          {
            int choice = 2;
            Random r = new Random();
            int genRAnd = r.Next(0, 2);


            if (choice == 2 && genRAnd == 1)
            {
              Console.WriteLine("My choice was PAPER");
              Console.WriteLine("You Win! Good Job " + player);
              playerScore++;
            }
            else if (choice == genRAnd)
            {
              Console.WriteLine("My choice was SCISSORS, also");
              Console.WriteLine("We tied!" + player);
              tieGame++;
            }
            else
            {
              Console.WriteLine("My choice was ROCK, I win");
              Console.WriteLine("Better luck next time!" + player);
              compScore++;
            }

          }
          else
          {
            Console.WriteLine("Please make a proper SELECTION... " + player.ToUpper());
          }
          Console.WriteLine(player + ": " + playerScore);
          Console.WriteLine(compScore + ": " + compScore);
          Console.WriteLine("Ties : " + tieGame);
          Console.WriteLine("Would you like to play again?");
          string finalAns = Console.ReadLine().ToLower();
          Console.Clear();
          if (finalAns == "no" || finalAns == "n")
          {
            done = true;
          }
        }
        if (start == "no" || start == "n")
        {
          done = true;
        }
      }
      else if (start == "no" || start == "n")
      {
        Console.WriteLine("Why did you start me then?");
        Console.WriteLine("That's kinda freakin weird!");
        Thread.Sleep(5000);
        Console.WriteLine("Fine... Have a good day!");


      }
      else
      {
        Console.WriteLine("Please make a proper selection...");
      }
    }
  }
}

