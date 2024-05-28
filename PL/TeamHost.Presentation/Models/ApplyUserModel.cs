using System.ComponentModel.DataAnnotations;

namespace TeamHost.Presentation.Models
{
    public class ApplyUserModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [EmailAddress]
        public IFormFile ProfilePhoto { get; set; }
    }
}
