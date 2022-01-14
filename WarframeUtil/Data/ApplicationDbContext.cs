using Microsoft.EntityFrameworkCore;

namespace WarframeUtil.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
            
        modelBuilder.Entity<Price>()
            .HasOne(x => x.RivenDbClass)
            .WithMany(x => x.Prices)
            .HasForeignKey(x => x.RivenDBClassId);
        modelBuilder.Entity<PriceAvg>()
            .HasOne(x => x.RivenDbClass)
            .WithMany(x => x.PriceAvg)
            .HasForeignKey(x => x.RivenDBClassId);
        modelBuilder.Entity<UnrolledAvg>()
            .HasOne(x => x.RivenDbClass)
            .WithMany(x => x.UnrolledAvg)
            .HasForeignKey(x => x.RivenDBClassId);
        modelBuilder.Entity<DbDate>()
            .HasOne(x => x.RivenDbClass)
            .WithMany(x => x.DDate)
            .HasForeignKey(x => x.RivenDBClassId);
            
    }

    public DbSet<RivenDBClass> Rivens { get; set; }
}