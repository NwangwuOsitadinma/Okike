using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okike.Model
{
    public class FoodGroup
    {
        public FoodGroup()
        {
            this.ID = Guid.NewGuid().ToString();
            this.FoodItems = new HashSet<FoodItem>();
        }
        public string ID { get; set; }
        public string Name { get; set; }
        public string ProfilePhoto { get; set; }

        public ICollection<FoodItem> FoodItems { get; set; }
        public ICollection<Vendor> Vendors { get; set; }
    }
}
