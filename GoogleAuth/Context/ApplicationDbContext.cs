using GoogleAuth.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GoogleAuth.Context
{
    public class AunctionAppDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public AunctionAppDbContext(DbContextOptions<AunctionAppDbContext> options) : base(options)
        {

        }
    }
}
