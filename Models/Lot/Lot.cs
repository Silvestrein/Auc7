namespace Auc7.Models.Lot
{
    public class Lot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public decimal Price { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime OpenTime { get; set; }
        public User.User Owner;
        public List<Bet> BetList { get; set; }
    }
}
