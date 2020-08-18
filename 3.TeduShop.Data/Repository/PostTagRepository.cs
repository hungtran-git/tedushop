using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IProductTagRepository
    {
    }
    public class ProductTagRepository : RepositoryBase<Product>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}