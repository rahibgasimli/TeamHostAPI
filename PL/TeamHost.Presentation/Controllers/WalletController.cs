using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamHost.Business.Services;
using TeamHost.DAL.Data;
using TeamHost.DAL.Entities;

namespace TeamHost.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        private readonly AppDbContext _context;

        public WalletController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("Wallet")]
        public async Task<ActionResult> GetWallet(Guid userId)
        {
            var usr = _context.Users.FirstOrDefault(u => u.Id == userId.ToString());
            
            if(usr == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(usr.Wallet);
            }
        }

        [HttpGet("Activities")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<List<Activities>>> GetActivities()
        {
            var usrId = Request.HttpContext.User.GetUserId();
            if(_context.Activities == null)
            {
                return NotFound();
            }
            return await _context.Activities.Where(a => a.User.Any(u => u.Id == usrId)).ToListAsync();

        }


    }
}
