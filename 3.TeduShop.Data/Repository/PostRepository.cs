using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IPostRepository
    {
    }
    public class PostRepository : RepositoryBase<Product>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}