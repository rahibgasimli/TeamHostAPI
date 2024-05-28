using System.ComponentModel.DataAnnotations;

namespace TeamHost.Presentation.Models
{
    public class LoginModel
    {
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
