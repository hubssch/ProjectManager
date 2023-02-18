using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectManager.Areas.Identity.Data;
using ProjectManager.Models;

namespace ProjectManager.Areas.Identity.Data;

public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "To do",
                
            },
            new Category
            {
                Id = 2,
                Name = "In progress",
            },
            new Category
            {
                Id = 3,
                Name = "Done",
            }
            );

        builder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 1,
                FirstName = "Hubert",
                LastName = "Schmidt",
                Mobile = 1234532,
            }
            );

        builder.Entity<Projects>().HasData(
            new Projects
            {
                Id = 1,
                Name = "testowy proejt",
                Description = "testowy desctr",
                CategoryID = 1,
                EmployeeID = 1,
            }
            );

        var hasher = new PasswordHasher<IdentityUser>();
        var user = new ApplicationUser
        {
            FirstName = "admin",
            LastName = "1",
            UserName = "admin@gmail.com",
            NormalizedUserName = "admin@GMAIL.COM",
            Email = "admin@gmail.com",
            NormalizedEmail = "admin@GMAIL.COM",
            EmailConfirmed = true,
            LockoutEnabled = true,
        };

        user.PasswordHash = hasher.HashPassword(user, "Ma4bach!");

        builder.Entity<ApplicationUser>().HasData(user);

        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
    private class ApplicationUserEntityConfiguration :
IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(255);
            builder.Property(x => x.LastName).HasMaxLength(255);
        }
    }
    public DbSet<ProjectManager.Models.Projects> Projects { get; set; }

    public DbSet<ProjectManager.Models.Category> Categories { get; set; }

    public DbSet<ProjectManager.Models.Employee> Employees { get; set; }

}
