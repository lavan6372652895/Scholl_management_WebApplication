using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholl_management_WebApplicationmodel.Model
{
    public class CreateuserModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LatName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Enter the vaild mail")]
        public string Mail { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        [Compare(nameof(password))]
        public string RePassword { get; set; }
        [Required]
        public int Branch { get; set; }
    }
}
