using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholl_management_WebApplicationmodel.Model
{
    public class CityModel
    {
      
        
        public int Id { get; set; }
        [Required]
        public string CityName { get; set; }
        [Required]
        public Nullable<int> CountryName { get; set; }
        [Required]
        public Nullable<int> StateName { get; set; }
    }
}
