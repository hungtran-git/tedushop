using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IPostTagRepository
    {
    }
    public class PostTagRepository : RepositoryBase<Product>, IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}