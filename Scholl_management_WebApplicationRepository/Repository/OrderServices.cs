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
   public  class OrderServices : OrderInterface1
    {
        lavan_386Entities1 dataobj = new lavan_386Entities1();
     
        public int Addorders(Ordermodel ord)
        {

            dataobj.AddProducttable(ord.ProductName, ord.Qtn);
            return 1;
        }

        public List<coupen> Coupenscode()
        {
            return dataobj.coupen.ToList();
        }

        public bool DeleteOrder(int id)
        {
            var result = dataobj.Orders.FirstOrDefault(x => x.orderId == id);
            if (result != null)
            {
                dataobj.Orders.Remove(result);
                dataobj.SaveChanges();
                return true;
            }
            return false;
        }

        public Ordermodel EditOrderd(int id)
        {
            var result = dataobj.Orders.FirstOrDefault(x => x.orderId == id);
            Ordermodel ordersmodel = new Ordermodel();
            ordersmodel.ProductName = result.ProductName;
            ordersmodel.Qtn = result.Qtn;
            return ordersmodel;


        }

        public List<Country> listcountries()
        {
            return dataobj.Country.ToList();
        }
        public List<Orders> orderslist()
        {
            return dataobj.Orders.ToList();
        }

        public List<Producttable> Producttableslist()
        {
            return dataobj.Producttable.ToList();
        }

        

        public bool UpdateOrder(int id, Ordermodel ordersmodel)
        {
            dataobj.updateorders(id, ordersmodel.ProductName, ordersmodel.Qtn);
            return true;
        }
      
    }
}
