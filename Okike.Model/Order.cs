using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okike.Model
{
    public class Order
    {
        public Order()
        {
            this.ID = Guid.NewGuid().ToString();
            this.FoodItems = new HashSet<FoodItem>();
        }

        public string ID { get; set; }
        public string OrderNumber { get; set; }
        public decimal  Price { get; set; }

        public ICollection<FoodItem> FoodItems { get; set; }
        public ICollection<FoodGroup> FoodGroups { get; set; }
    }
}
