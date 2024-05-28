namespace TeamHost.DAL.Entities
{
    public class Activities : BaseEntity
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public string PhotoPath { get; set; }
        public List<AppUser> User { get; set; }
    }
}
