using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface ISystemConfigRepository
    {
    }
    public class SystemConfigRepository : RepositoryBase<Product>, ISystemConfigRepository
    {
        public SystemConfigRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}