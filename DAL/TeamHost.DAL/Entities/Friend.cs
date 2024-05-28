using TeamHost.DAL.Enums;

namespace TeamHost.DAL.Entities
{
    public class Friend : BaseEntity
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string ProfilePhoto { get; set; }
        public List<AppUser> Users { get; set; }
        public FriendshipStatus Pending { get; set; }
    }
}
