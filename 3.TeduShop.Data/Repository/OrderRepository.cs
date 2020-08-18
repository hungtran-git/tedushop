using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IOrderRepository
    {
    }
    public class OrderRepository : RepositoryBase<Product>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}