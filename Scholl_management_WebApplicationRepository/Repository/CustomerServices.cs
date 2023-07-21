using Scholl_management_WebApplicationHelper.Helper;
using Scholl_management_WebApplicationmodel.Dbconnection;
using Scholl_management_WebApplicationmodel.Model;
using Scholl_management_WebApplicationRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholl_management_WebApplicationRepository.Repository
{
    public class CustomerServices : customerinterface
    {
        lavan_386Entities1 db = new lavan_386Entities1();
        Customerhelper Customerhelper = new Customerhelper();
        public int AddNewCustomer(CustomerModel customer)
        {
            var Emailr = db.customer.FirstOrDefault(x => x.Email == customer.Email);
            if(Emailr == null)
            {
                db.customer.Add(Customerhelper.Binddata(customer));
                db.SaveChanges();
                return 1;
            }
            return 0;
        }

        public List<customer> dblist()
        {
            return db.customer.ToList();
        }
    }
}
