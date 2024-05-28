using TeamHost.DAL.Entities;

namespace TeamHost.Presentation.Models
{
    public class GameModel
    {
        public string ProfilePhoto { get; set; }
        public string Name { get; set; }
        public List<GameTag> GameTags { get; set; }
        public double Rating { get; set; }
        public double Price { get; set; }
    }
}
