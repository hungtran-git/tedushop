using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetAllByTagPaging(int page, int pageSize, out int totalRow, int productCategoryId, string tag);
    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
        public IEnumerable<Product> GetAllByTagPaging(int page, int pageSize, out int totalRow, int productCategoryId, string tag)
        {
            var query = from p in this.DbContext.Products
                        join pt in DbContext.ProductTags
                        on p.Id equals pt.ProductId
                        where p.Status &&
                                (productCategoryId == 0 || p.CategoryId == productCategoryId) &&
                                pt.TagId == tag
                        select p;
            totalRow = query.Count();
            return query.Skip((page - 1) * pageSize).Take(pageSize);
        }

    }
}