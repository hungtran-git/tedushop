using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IOrderDetailRepository
    {
    }
    public class OrderDetailRepository : RepositoryBase<Product>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}