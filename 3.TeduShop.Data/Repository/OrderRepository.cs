using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IOrderRepository : IRepository<OrderDetail>
    {
    }
    public class OrderRepository : RepositoryBase<OrderDetail>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}