using Okike.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okike.Data.Configuration
{
    class FoodGroupConfiguration : EntityTypeConfiguration<FoodGroup>
    {
        public FoodGroupConfiguration()
        {
            HasKey(m => m.ID);
            Property(m => m.Name).IsRequired();
        }
    }
}
