using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholl_management_WebApplicationmodel.Model
{
    public class Ordermodel
    {
        public Nullable<int> ProductName { get; set; }
        public Nullable<int> Qtn { get; set; }
        public int Coupencode { get; set; }
    }
}
