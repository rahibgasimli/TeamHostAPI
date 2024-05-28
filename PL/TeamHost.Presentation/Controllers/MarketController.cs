using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamHost.Business.Services;
using TeamHost.DAL.Data;
using TeamHost.DAL.Entities;

namespace TeamHost.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MarketController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("Search")]
        public async Task<ActionResult> Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return NotFound();
            }

            var marketItems = _context
                .MarketCards
                .Where(m => m.ItemName.ToLower().Contains(query.ToLower())).ToList();

            if (marketItems.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(marketItems);
            }
        }



        [HttpGet("GetCards")]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<List<MarketCard>>> GetCards()
        {
            if (_context.MarketCards == null)
            {
                return NotFound();
            }
            return await _context.MarketCards.ToListAsync();
        }



    }
}
