using Microsoft.EntityFrameworkCore;

namespace BlazorShopping.Data.Context
{
    /// <summary>
    /// To create a new migration run this command in the Package Manager Console:
    ///     Add-Migration -Name "YOUR MIGRATION NAME" -OutputDir "Data\Migrations" 
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ShoppingItem> ShoppingItems { get; set; }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Section> Sections { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShoppingItem>(b =>
            {
                b.Property(p => p.ArticleName).HasMaxLength(100);
                b.Property(p => p.ArticleUnit).HasMaxLength(5);
                b.Property(p => p.SectionName).HasMaxLength(100);
            });

            modelBuilder.Entity<Article>(b =>
            {
                b.Property(p => p.Name).HasMaxLength(100);
                b.Property(p => p.Unit).HasMaxLength(5);
            });

            modelBuilder.Entity<Section>(b =>
            {
                b.Property(p => p.Name).HasMaxLength(100);
            });
        }
    }

}
