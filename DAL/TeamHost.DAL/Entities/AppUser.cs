using Microsoft.AspNetCore.Identity;

namespace TeamHost.DAL.Entities
{
    public class AppUser : IdentityUser
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string ProfilePhoto { get; set; }
        public byte Followers { get; set; }
        public byte Posts { get; set; }
        public double Wallet { get; set; }
        public List<GroupsEntity> Groups { get; set; }
        public List<Friendship> Friendships { get; set; }
        public List<Activities> Activities { get; set; }
        public List<UserComment> Comments { get; set; }
    }
}
