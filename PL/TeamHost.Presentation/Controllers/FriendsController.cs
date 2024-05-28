using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamHost.Business.Services;
using TeamHost.DAL.Data;
using TeamHost.DAL.Entities;
using TeamHost.DAL.Enums;

namespace TeamHost.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FriendsController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet("Search")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult> Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return NotFound();
            }
            // JWT-den Id-ni gotururuk
            var usrId = User.GetUserId();
            // Id-ye gore useri tapiriq
            var friendships = await _context.Friendships
                .Include(fs => fs.Friends)
                .Where(fs => fs.Friends.Any(f => f.Id == usrId) && fs.Friends.Any(f => f.FName.Contains(query) || f.LName.Contains(query)))
                .ToListAsync();

            if (friendships.Count == 0)
                return NotFound();

      
            //var friends = usr
            //    .Friendships
            //    .Where(f => f.FName.ToLower().Contains(query.ToLower()) || f.LName.ToLower().Contains(query.ToLower())).ToList();

            //if(friends.Count == 0)
            //{
            //    return NotFound();
            //}
            //else
            //{
            //    return Ok(friends);
            //}
            throw new NotImplementedException();
        }

        [HttpGet("FriendsList")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<List<Friend>>> GetFriends()
        {
            var userId = User.GetUserId();

            var usr = _context.Users
                .Include(u => u.Friendships)
                .ThenInclude(f => f.Friends)
                .FirstOrDefault(u => u.Id == userId);

            if (usr == null || usr.Friendships == null)
            {
                return NotFound();
            }

            var friends = usr.Friendships.Select(fs => fs.Friends.FirstOrDefault(f => f.Id != usr.Id)).ToList();

            return Ok(friends.Select(f => new
            {
                Name = f.FName + f.LName,
                ProfilePhoto = f.ProfilePhoto
            }));
        }

        [HttpPost("AddFriend")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> AddFriend([FromForm] Guid userId)
        {
            var usr = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId.ToString());

            if (usr == null)
                return NotFound("Bele bir istifadeci yoxdur");

            var jwtUsrId = User.GetUserId();

            var jwtUsr = await _context.Users
                .Include(u => u.Friendships)
                .ThenInclude(f => f.Friends)
                .FirstOrDefaultAsync(u => u.Id == jwtUsrId.ToString());

            if (jwtUsr == null)
                return BadRequest("Melumatlar yanlisdir");

            // evvelceden bele bir dostlugu varmi
            if (jwtUsr.Friendships.Any(f => f.Friends.Contains(usr)))
                return BadRequest("Zaten dostluq atilib");

            await _context.Friendships.AddAsync(new Friendship()
            {
                Id = Guid.NewGuid(),
                Status = FriendshipStatus.Pending,
                CreatedDate = DateTime.Now,
                Friends = new List<AppUser>() { jwtUsr, usr}
            });
            await _context.SaveChangesAsync();

            return Ok("Dostluq gonderildi");
        }
    }
}
