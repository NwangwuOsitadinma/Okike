
using Okike.Data.Infrastructure;
using Okike.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okike.Data.Repository
{
    public class FoodItemRepository : Infrastructure.RepositoryBase<FoodItem>, IFoodItemRepository
    {
        public FoodItemRepository(IDatabaseFactory dataFac) : base(dataFac)
        {
        }
    }


    public interface IFoodItemRepository : IRepository<FoodItem>
    {

    }
}
