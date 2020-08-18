using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IPageRepository
    {
    }
    public class PageRepository : RepositoryBase<Product>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}