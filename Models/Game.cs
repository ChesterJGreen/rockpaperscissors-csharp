using System.Collections.Generic;

namespace rockpaperscissors_csharp.Models
{
  public class Game
  {
    public List<Computer> Computer { get; set; } = new Computer();
    public List<Player> Player { get; set; } = new Player();
    public void Choose(Computer computer)
    {
      Computer.Add(computer);
    }
    public void Choose(Player player);
    {
    Player.Add(player);
    }
}
}