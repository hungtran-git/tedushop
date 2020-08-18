using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IMenuRepository
    {
    }
    public class MenuRepository : RepositoryBase<Product>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}