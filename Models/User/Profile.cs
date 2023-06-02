using Auc7.Models.Lot;
using System.Data;

namespace Auc7.Models.User
{
    public class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Roles Role { get; set; }
        public decimal Balance { get; set; }
        public List<int> BetsID { get; set; }
        public string Email { get; set;}
        public string Password { get; set;}

    }
}
