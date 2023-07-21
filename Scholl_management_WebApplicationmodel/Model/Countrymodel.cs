using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholl_management_WebApplicationmodel.Model
{
    public class Countrymodel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string CountryName { get; set; }
    }
}
