using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstate.Models.Estate;
using RealEstate.Models.Owner;

namespace RealEstate.Data;

public class ApplicationDbContext : IdentityDbContext<Person, IdentityRole<Guid>, Guid>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Real Estate
    // public DbSet<RealEstateCategory> RealEstateCategories { get; set; } = null!;
    // public DbSet<RealEstateSubCategory> RealEstateSubCategories { get; set; } = null!;
    // public DbSet<Models.Estate.RealEstate> RealEstates { get; set; } = null!;
    // public DbSet<RealEstateImages> RealEstateImages { get; set; } = null!;
}