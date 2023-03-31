using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace appserverproject.Data
{
    internal static class PromosRepository
    {
        internal async static Task<List<Promo>> GetPromosAsync()
        {
            using (var db = new AppDBContext())
            {
                return await db.Promos.ToListAsync();
            }
        }
        internal async static Task<Promo> GetPromoByIdAsync(int promoId)
        {
            using (var db = new AppDBContext())
            {
                return await db.Promos
                    .FirstOrDefaultAsync(promo => promo.PromoId == promoId);
            }
        }
        internal async static Task<bool> CreatePromoAsync(Promo promoToCreate)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    await db.Promos.AddAsync(promoToCreate);

                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
        internal async static Task<bool> UpdatePromoAsync(Promo promoToUpdate)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    db.Promos.Update(promoToUpdate);

                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
        internal async static Task<bool> DeletePromoAsync(int promoId)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    Promo promoToDelete = await GetPromoByIdAsync(promoId);
                    db.Remove(promoToDelete);

                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
    }
}
