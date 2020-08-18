using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductTagRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductTagRepository(IDbFactory dbFactory):base(dbFactory)
        {
             
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x=>x.Alias == alias);
        }
    }
}