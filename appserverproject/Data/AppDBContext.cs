using Microsoft.EntityFrameworkCore;

namespace appserverproject.Data
{
    internal sealed class AppDBContext : DbContext
    {
        public DbSet<Promo> Promos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source=./Data/AppDB.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Promo[] promosToSeed = new Promo[6];

            for (int i = 1; i <= promosToSeed.Length; i++)
            {
                promosToSeed[i - 1] = new Promo
                {
                    PromoId = i,
                    PromoTitle = $"Promo {i}",
                    PromoType = 1,
                    PromoCurrency = 1,
                    PromoStart = new DateTime(),
                    PromoEnd = new DateTime(),
                };
            }

            modelBuilder.Entity<Promo>().HasData(promosToSeed);
        }
    }
}
