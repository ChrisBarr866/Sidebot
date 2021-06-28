

namespace SideBot
{
    public class Player
    {
        // public int AmountOfCards 
        // { 
        //     get { return this.Cards.len();}
        //     set { AmountOfCards = value;}
        // }
        public bool Has21 { get; set; }
        public bool HasBlackjack { get; set; }
        public string FirstName { get; set; }
        public int UserID { get; set; }
        public int Wins { get; set; }
        // public List<Card> Cards = new List<Card>();

        // public DrawCard(Player)
        // {
        //     this.GetCurrentPlayer() = Player
        // }
        


        public Player(int UserID, string FirstName)
        {
            this.UserID = UserID;
            this.FirstName = FirstName;
            Has21 = false;
            HasBlackjack = false;
        }
    }
}