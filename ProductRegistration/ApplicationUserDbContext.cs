using Microsoft.EntityFrameworkCore;
using ProductRegistration.Models;
using System.Collections.Generic;

namespace ProductRegistration;

public class ApplicationUserDbContext : DbContext
{
    public ApplicationUserDbContext(DbContextOptions<ApplicationUserDbContext> options) : base(options)
    {

    }
    public DbSet<Student> Students { get; set; }
    public DbSet<Product> Products { get; set; }
}
