using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlackCoderMotoCrossMadnessApp.Areas.security.Models;
using BlackCoderMotoCrossMadnessApp.Models;
using BlackCoderMotoCrossMadnessApp.ViewModels;

namespace BlackCoderMotoCrossMadnessApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<CompanyUser>()
                .HasKey(x => new { x.CompanyID, x.ApplicationUserID });
        }

        public DbSet<BlackCoderMotoCrossMadnessApp.Models.ApplicationRole> ApplicationRole { get; set; }

        public DbSet<BlackCoderMotoCrossMadnessApp.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<BlackCoderMotoCrossMadnessApp.Areas.security.Models.Company> Company { get; set; }

        public DbSet<BlackCoderMotoCrossMadnessApp.Areas.security.Models.CompanyUser> CompanyUser { get; set; }

        public DbSet<BlackCoderMotoCrossMadnessApp.ViewModels.Module> Module { get; set; }
        
    }
}
