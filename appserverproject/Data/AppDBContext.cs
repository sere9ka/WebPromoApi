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
                    PromoTitle = $"Post {i}",
                    PromoType = 1,
                    PromoCurrency = 1,
                    PromoStart = "28.09.2022",
                    PromoEnd = "30.09.2022",
                };
            }

            modelBuilder.Entity<Promo>().HasData(promosToSeed);
        }
    }
}
