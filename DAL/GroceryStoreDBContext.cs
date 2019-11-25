using DAL.Models;
using System.Data.Entity;

namespace DAL
{
    public class GroceryStoreDBContext : DbContext
    {
        public GroceryStoreDBContext()
           : base("DefaultConnection")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<GameDBContext, Migrations.Configuration>());
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Models.Type> Types { get; set; }
        public DbSet<Gemstone> Gemstones { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            base.OnModelCreating(dbModelBuilder);

            dbModelBuilder.Entity<Product>()
                .HasMany(c => c.Gemstones)
                .WithOptional(c => c.Product)
                .HasForeignKey(c => c.ProductId);

            dbModelBuilder.Entity<Models.Type>()
                .HasMany(c => c.Products)
                .WithRequired(c => c.Type)
                .HasForeignKey(c => c.TypeId);
        }
    }
}
