using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamHost.DAL.Data;
using TeamHost.DAL.Entities;

namespace TeamHost.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public IActionResult<HomeModel> Home()
        //{
        //    var games = _context.Games.Select(g => new GameModel
        //    {
        //        Name = g.Name,
        //        Price = g.Price,
        //        Rating = g.Reviews,
        //        ProfilePhoto = g.PhotoPath,
        //        GameTags = g.GameTags
        //    }).ToList();

        //    var bannerPhotos = _context.BannerPhotos.Select(g => g.PhotoPath).ToList();


        //    var homeModel = new HomeModel
        //    {
        //        Games = games,
        //        BannerPhotos = bannerPhotos
        //    };

        //    return Ok(homeModel);
        //}



        [HttpGet("GetGames")]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<List<Game>>> GetGames()
        {
            // select top(5)
            var games = await _context.Games
                .Take(5)
                .Include(g => g.GameTags)
                .OrderByDescending(g => g.CreatedDate)
                .ToListAsync();

            if (games == null)
            {
                return NotFound();
            }
            return Ok(games);

        }

        [HttpGet("GetBannerPhotos")]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<List<BannerPhoto>>> GetBannerPhoto()
        {

            if (_context.BannerPhotos == null)
            {
                return NotFound();
            }
            return await _context.BannerPhotos
                .Take(5)
                .OrderByDescending(b => b.CreatedDate)
                .ToListAsync();
        }


        [HttpGet("Communities")]
        public async Task<ActionResult<List<GroupsEntity>>> GetCommunities()
        {
            if (_context.GroupsTables == null)
            {
                return NotFound();
            }
            return await _context.GroupsTables
                .Take(5)
                .OrderByDescending(b => b.CreatedDate)
                .ToListAsync();
        }


    }
}
