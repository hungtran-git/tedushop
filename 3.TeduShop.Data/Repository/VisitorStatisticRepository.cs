using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IVisitorStatisticRepository
    {
    }
    public class VisitorStatisticRepository : RepositoryBase<Product>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}