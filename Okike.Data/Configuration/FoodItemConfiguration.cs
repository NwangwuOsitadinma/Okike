using Okike.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okike.Data.Configuration
{
    public class FoodItemConfiguration : EntityTypeConfiguration<FoodItem>
    {
        public FoodItemConfiguration()
        {
            HasKey(m => m.ID);
            Property(m => m.Name).IsRequired();
            HasMany(m => m.FoodGroups).WithMany(m => m.FoodItems)
                .Map(t => 
                {
                    t.MapLeftKey("FoodGroupId");
                    t.MapRightKey("FoodItemsId");
                    t.ToTable("FoodGroupItems");
                });
        }
    }
}
