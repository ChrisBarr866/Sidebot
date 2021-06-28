using System.Collections.Generic;

namespace SideBot
{
    public class BlackJack
    {
        List<Player> players = new List<Player>();
        List<Player> bustedPlayers = new List<Player>();
        public Player CurrentPlayer { get; set; }
        enum GameType
        {
            Singleplayer = 1,
            Multiplayer_Direct = 2
        }

        Deck deck = new Deck();
    //    static StopGame()
    //    NextPlayer(CurrentPlayer);

    //    EvaluateHands();
        
    }
}