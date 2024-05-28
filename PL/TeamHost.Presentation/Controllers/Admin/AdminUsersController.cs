using Humanizer;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamHost.Business.Abstractions;
using TeamHost.Business.Interfaces;
using TeamHost.Business.Services;
using TeamHost.DAL.Data;
using TeamHost.DAL.Entities;
using TeamHost.DAL.Enums;
using TeamHost.Presentation.Models;

namespace TeamHost.Presentation.Controllers.Admin;

[Route("api/[controller]")]
[ApiController]


public class AdminUsersController : ControllerBase
{
    private readonly UserManager<AppUser> _userManager;
    private readonly ITokenService _tokenService;
    private readonly IWebHostEnvironment _env;
    private readonly AppDbContext _context;
    private readonly IStorageService _storageService;

    public AdminUsersController(UserManager<AppUser> userManager, ITokenService tokenService, IWebHostEnvironment env, AppDbContext context, IStorageService storageService)
    {
        _userManager = userManager;
        _tokenService = tokenService;
        _env = env;
        _context = context;
        _storageService = storageService;
    }

    [HttpGet("Users")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = nameof(RoleTypes.Admin))]
    public async Task<ActionResult<List<AppUser>>> GetUsers()
    {


        return Ok(await _context.Users.ToListAsync());
    }

    [HttpGet("Edit")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = nameof(RoleTypes.Admin))]
    public async Task<IActionResult> Edit(string id, [FromForm] RegisterModel dto)
    {
        var usr = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);

        if (usr == null)
        {
            return NotFound();
        }

        var path = Path.Combine(_env.WebRootPath, "uploads", dto.ProfilePhoto.FileName);
        var fs = System.IO.File.Open(path, FileMode.Create);
        await dto.ProfilePhoto.CopyToAsync(fs);
        fs.Close();

        var editDetails = new EditUserModel()
        {
            Id= Guid.Parse(usr.Id),
            UserName= usr.UserName,
            Email= usr.Email,
            FirstName = usr.FName,
            LastName = usr.LName,
            ProfilePhoto = path         
        };

        return Ok(editDetails);
    }

    [HttpPost("Edit")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = nameof(RoleTypes.Admin))]
    public async Task<IActionResult> Edit(ApplyUserModel model)
    {

        if (!ModelState.IsValid)
        {
            return Ok(model);
        }

        var usr = await _context.Users.FirstOrDefaultAsync(u => u.Id == model.Id.ToString());

        if (usr == null)
        {
            return NotFound("Istifadeci Tapilmadi");
        }

        usr.UserName = model.UserName;
        usr.FName = model.FirstName;
        usr.LName = model.LastName;
        usr.Email = model.Email;

        if (model.ProfilePhoto != null)
        {
            var dto = await _storageService.UploadFileAsync("profile-photos", model.ProfilePhoto);

            if (_storageService is LocalStorageService)
            {
                dto.FullPath = $"uploads/{dto.FullPath}";
            }

            usr.ProfilePhoto = dto.FullPath;
        }

        var res = await _userManager.UpdateAsync(usr);

        if (!res.Succeeded)
        {
            return NotFound();
        }

        return RedirectToAction("AllUsers");
    }




}
