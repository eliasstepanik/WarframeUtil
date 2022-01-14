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
            
        /*modelBuilder.Entity<Product.ImagePath>()
            .HasOne(x => x.Product)
            .WithMany(x => x.AdditionalImages)
            .HasForeignKey(x => x.ProductId);*/
       
            
    }

    //public DbSet<WarframeItem> WarframeItems { get; set; }
}