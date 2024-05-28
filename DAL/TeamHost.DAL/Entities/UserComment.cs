namespace TeamHost.DAL.Entities
{
    public class UserComment : BaseEntity
    {
        public string CommentText { get; set; }
        public AppUser AppUser { get; set; }
    }
}
