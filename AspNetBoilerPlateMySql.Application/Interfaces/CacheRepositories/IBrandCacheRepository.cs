using AspNetBoilerPlateMySql.Domain.Entities.Catalog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetBoilerPlateMySql.Application.Interfaces.CacheRepositories
{
    public interface IProductCacheRepository
    {
        Task<List<Product>> GetCachedListAsync();

        Task<Product> GetByIdAsync(int brandId);
    }
}