namespace TeamHost.DAL.Entities
{
    public class Game : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }
        public double Reviews { get; set; }
        public double Price { get; set; }
        public List<GameTag> GameTags { get; set; }
    }
}
