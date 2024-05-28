using TeamHost.DAL.Entities;

namespace TeamHost.Presentation.Models
{
    public class HomeModel
    {
        public List<GameModel> Games { get; set; }
        public List<string> BannerPhotos { get; set; }
    }
}
