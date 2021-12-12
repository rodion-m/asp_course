using Microsoft.EntityFrameworkCore;

namespace Lesson5.Data;

public class AppDbContext : DbContext
{
    public DbSet<Order> Orders => Set<Order>();

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}