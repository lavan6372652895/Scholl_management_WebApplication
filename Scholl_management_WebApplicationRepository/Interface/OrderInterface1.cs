using Scholl_management_WebApplicationmodel.Dbconnection;
using Scholl_management_WebApplicationmodel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholl_management_WebApplicationRepository.Interface
{
   public interface OrderInterface1
    {
        List<Producttable> Producttableslist();
       
       
        List<Country> listcountries();
        int Addorders(Ordermodel ord);
        List<Orders> orderslist();
        Ordermodel EditOrderd(int id);
        bool UpdateOrder(int id, Ordermodel ordersmodel);
        bool DeleteOrder(int id);
        List<coupen> Coupenscode();
 
    }
}
