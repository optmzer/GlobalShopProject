using GlobalShopProject.Data.Models;
using GlobalShopProject.Data.Models.Catalog;
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
        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<CatalogBrand> CatalogBrands { get; set; }
        public DbSet<CatalogType> CatalogTypes { get; set; }


        // Configuration of Constraints




    }
}
