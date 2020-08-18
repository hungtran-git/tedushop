using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IPostCategoryRepository
    {
    }
    public class PostCategoryRepository : RepositoryBase<Product>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}