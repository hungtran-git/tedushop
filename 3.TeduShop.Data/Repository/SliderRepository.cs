using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface ISliderRepository : IRepository<Slider>
    {
    }
    public class SliderRepository : RepositoryBase<Slider>, ISliderRepository
    {
        public SliderRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}