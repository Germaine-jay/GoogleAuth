using Microsoft.AspNetCore.Identity;

namespace GoogleAuth.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string? CreatedAt { get; set; }
    }
}
