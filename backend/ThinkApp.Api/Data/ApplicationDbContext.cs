using Microsoft.EntityFrameworkCore;
using ThinkApp.Api.Models;

namespace ThinkApp.Api.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Think> Thinks { get; set; }
}