using Scholl_management_WebApplicationmodel.Dbconnection;
using Scholl_management_WebApplicationmodel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholl_management_WebApplicationRepository.Interface
{
    public interface customerinterface
    {
        List<customer> dblist();
        int AddNewCustomer(CustomerModel customer);
    }
}
