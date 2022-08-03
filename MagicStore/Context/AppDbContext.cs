using MagicStore.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicStore.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Card> Cards { get; set; }
}