using Microsoft.EntityFrameworkCore;

namespace NamingSystem.Core.DbContext;

public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<NameIdea> NameIdeas { get; set; }
    public DbSet<Reaction> Reactions { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Reaction>()
            .HasKey(r => new { r.UserId, r.NameIdeaID, });
        modelBuilder.Entity<Reaction>()
            .HasOne(r => r.User)
            .WithMany(u => u.Reactions)
            .HasForeignKey(r => r.UserId);
        modelBuilder.Entity<Reaction>()
            .HasOne(r => r.NameIdea)
            .WithMany(n => n.Reactions)
            .HasForeignKey(r => r.NameIdeaID);
    }
}