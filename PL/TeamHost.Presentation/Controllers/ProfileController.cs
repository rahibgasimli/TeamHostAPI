using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamHost.DAL.Data;
using TeamHost.DAL.Entities;
using TeamHost.Presentation.Models;

namespace TeamHost.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProfileController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("ProfileInfo")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult> GetProfile(Guid userId)
        {
            var usr = _context.Users.FirstOrDefault(u => u.Id == userId.ToString());

            if(usr == null)
            {
                return NotFound();
            }
            else
            {
                var model = new ProfileModel
                {
                    FullName = $"{usr.FName} {usr.LName}",
                    UserName = usr.UserName,
                    Followers = usr.Followers,
                    Posts = usr.Posts,
                    PhotoPath = usr.ProfilePhoto
                };
                return Ok(model);
            }
        }

        //[HttpGet("Friends")]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        //public async Task<ActionResult<List<Friend>>> GetFriends(Guid userId)
        //{
        //    var usr = _context.Users.Include(u => u.Friendships).FirstOrDefault(u => u.Id == userId.ToString());

        //    if (usr == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(usr.Friendships);
        //}

        [HttpGet("Comment")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<List<UserComment>>> GetComment(Guid userId)
        {
            var comments = await _context.UserComments.Where(c => c.AppUser.Id == userId.ToString()).ToListAsync();

            if (comments == null)
            {
                return NotFound();
            }

            return Ok(comments);
        }
    }
}
