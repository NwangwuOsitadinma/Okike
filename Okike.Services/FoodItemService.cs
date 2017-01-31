using Okike.Data.Infrastructure;
using Okike.Data.Repository;
using Okike.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okike.Services
{
    public interface IFoodItemService
    {
        void AddFoodItem(FoodItem entity);
    }

    public class FoodItemService : IFoodItemService
    {
        private RepositoryBase<FoodItem> _repository;

        public FoodItemService(FoodItemRepository _repo)
        {
            _repository = _repo;
        }


        public void AddFoodItem(FoodItem entity)
        {
            _repository.Add(entity);
        }
    }


}
