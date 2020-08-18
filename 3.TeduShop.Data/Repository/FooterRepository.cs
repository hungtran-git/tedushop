using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IFooterRepository
    {
    }
    public class FooterRepository : RepositoryBase<Product>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}