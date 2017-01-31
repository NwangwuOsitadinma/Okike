using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okike.Model
{
    public class FoodItem
    {
        public FoodItem()
        {
            this.ID = Guid.NewGuid().ToString();
            this.Vendors = new HashSet<Vendor>();
            this.FoodGroups = new HashSet<FoodGroup>();
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string ProfilePhoto { get; set; }

        public ICollection<Vendor> Vendors { get; set; }
        public ICollection<FoodGroup> FoodGroups { get; set; }

    }
}
