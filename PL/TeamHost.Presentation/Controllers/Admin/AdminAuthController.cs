using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TeamHost.Business.Interfaces;
using TeamHost.DAL.Entities;
using TeamHost.DAL.Enums;
using TeamHost.Presentation.Models;

namespace TeamHost.Presentation.Controllers.Admin
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = nameof(RoleTypes.Admin))]
    public class AdminAuthController : ControllerBase
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly ITokenService _tokenService;
        private readonly IWebHostEnvironment _env;

        public AdminAuthController(UserManager<AppUser> userManager, ITokenService tokenService, IWebHostEnvironment env)
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _env = env;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromForm] LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usr = await _userManager.FindByEmailAsync(model.Email);

            if (usr == null)
            {
                ModelState.AddModelError("AuthError", "Email or password is wrong");
                return BadRequest(ModelState);
            }

            var passMatch = await _userManager.CheckPasswordAsync(usr, model.Password);

            if (!passMatch)
            {
                ModelState.AddModelError("AuthError", "Email or password is wrong");
                return BadRequest(ModelState);
            }

            var token = _tokenService.GenerateToken(usr, nameof(UserRole.Admin));

            return Ok(new
            {
                Message = "Successfully logged in",
                Token = token,
            });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromForm] RegisterModel dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var path = Path.Combine(_env.WebRootPath, "uploads", dto.ProfilePhoto.FileName);
            var fs = System.IO.File.Open(path, FileMode.Create);
            await dto.ProfilePhoto.CopyToAsync(fs);
            fs.Close();

            var usr = new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                FName = dto.FirstName,
                LName = dto.LastName,
                Email = dto.Email,
                UserName = dto.FirstName.ToLower() + dto.LastName.ToLower(),
                ProfilePhoto = path
            };

            var res = await _userManager.CreateAsync(usr, dto.Password);

            if (!res.Succeeded)
            {
                var errors = res.Errors.Select(e => e.Description).ToList();
                var errorStr = string.Join("\n", errors);

                ModelState.AddModelError("AuthError", errorStr);

                return BadRequest(errorStr);
            }

            var roleRes = await _userManager.AddToRoleAsync(usr, nameof(RoleTypes.Admin));

            if (!roleRes.Succeeded)
            {
                var errors = roleRes.Errors.Select(e => e.Description).ToList();
                var errorStr = string.Join("\n", errors);

                ModelState.AddModelError("AuthError", errorStr);

                return BadRequest(errorStr);
            }

            return Created("Register", usr);
        }


    }
}
