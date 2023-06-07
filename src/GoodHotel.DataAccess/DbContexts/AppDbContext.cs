using GoodHotel.Domain.Entities.New;
using GoodHotel.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace GoodHotel.DataAccess.DbContexts;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; } = default!;
    public virtual DbSet<Room> Rooms { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
