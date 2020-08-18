using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface ISupportOnlineRepository
    {
    }
    public class SupportOnlineRepository : RepositoryBase<Product>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}