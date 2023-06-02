namespace Auc7.Models.Lot
{
    public class Bet
    {
        public decimal Price { get; set; }
        public int ID { get; set; }
        public User.User Buyer;
        public DateTime BetTime { get; set; }
    }
}
