using Scholl_management_WebApplicationmodel.Dbconnection;
using Scholl_management_WebApplicationmodel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholl_management_WebApplicationHelper.Helper
{
    public class Customerhelper
    {
        public customer Binddata(CustomerModel customer)
        {
            customer newCustomer = new customer();
            newCustomer.customer_Name = customer.customer_Name;
            newCustomer.Email = customer.Email;
            newCustomer.Gender = customer.Gender;
            newCustomer.password = customer.password;
            newCustomer.Country = customer.Country;
            newCustomer.States = customer.States;
            newCustomer.city = customer.city;
            return newCustomer;
        }
    }
}
