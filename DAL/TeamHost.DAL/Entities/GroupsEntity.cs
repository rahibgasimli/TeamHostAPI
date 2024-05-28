namespace TeamHost.DAL.Entities
{
    public class GroupsEntity : BaseEntity
    {
        public string Name { get; set; }
        public string GroupStatus { get; set; }
        public byte Post { get; set; }
        public DateTime LastActive { get; set; }
        public string ProfilePhoto { get; set; }
        public List<AppUser> Members { get; set; }
    }
}
