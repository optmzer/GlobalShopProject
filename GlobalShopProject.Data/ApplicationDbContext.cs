using GlobalShopProject.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GlobalShopProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            // Leave empty
        }
        // Design Db and
        // Add DbSet you are going to use

    }
}
