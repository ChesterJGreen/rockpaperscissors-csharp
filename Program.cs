using System;

namespace rockpaperscissors_csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Would you like to play Rock Paper Scissors?");
      string start = Console.ReadLine().ToLower();
      Console.WriteLine("What is your name?");
      string player = Console.ReadLine();
      Console.WriteLine("Which item do you pick?");
      Console.WriteLine("Rock Paper or Scissors?");
      string selection = Console.ReadLine().ToLower();
      if (selection == "rock")
      {
        int choice = 0;
        Random r = new Random();
        int genRAnd = r.Next(0, 2);
        if (choice < genRAnd && genRAnd == 2)
        {
          Console.WriteLine("My choice was Scissors");
          Console.WriteLine("You Win! Good Job " + player);

        }
        else if (choice == genRAnd)
        {
          Console.WriteLine("My choice was Rock, also");
          Console.WriteLine("We tied!" + player);
        }
        else
        {
          Console.WriteLine("My choice was paper, I win");
          Console.WriteLine("Better luck next time!" + player);
        }
      }
      if (selection == "paper")
      {
        int choice = 1;
        Random r = new Random();
        int genRAnd = r.Next(0, 2);
        string compChoice = genRAnd.ToString();

        if (choice > genRAnd)
        {
          Console.WriteLine("My number was " + genRAnd);
          Console.WriteLine("You Win! Good Job " + player);

        }

      }
      if (selection == "scissors")
      {
        int choice = 2;
        Random r = new Random();
        int genRAnd = r.Next(0, 2);


        if (choice > genRAnd)
        {
          Console.WriteLine("My number was " + genRAnd);
          Console.WriteLine("You Win! Good Job " + player);

        }

      }


    }
  }
}
