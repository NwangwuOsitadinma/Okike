using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okike.Model
{
    public class Vendor
    {
        public Vendor()
        {
            this.ID = Guid.NewGuid().ToString();

        }
        [ForeignKey("ApplicationUser")]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ProfilePhoto { get; set; }
        
        public ApplicationUser ApplicationUser { get; set; }

    }
}
