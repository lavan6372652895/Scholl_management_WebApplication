using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholl_management_WebApplicationmodel.Model
{
    public class CustomerModel
    {
       
        public int customer_id { get; set; }
        [Required]
        public string customer_Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public Nullable<int> Country { get; set; }
        [Required]
        public Nullable<int> States { get; set; }
        [Required]
        public Nullable<int> city { get; set; }
        [Required]
        public string Gender { get; set; }

    }
}
