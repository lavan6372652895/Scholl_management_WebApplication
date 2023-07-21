using Scholl_management_WebApplicationmodel.Dbconnection;
using Scholl_management_WebApplicationmodel.Model;
using Scholl_management_WebApplicationRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scholl_management_WebApplication.Controllers
{
    public class OrderController : Controller
    {
       
            lavan_386Entities1 dataobj = new lavan_386Entities1();
            public OrderInterface1 _OrderInterface1;
            public OrderController(OrderInterface1 @interface)
            {
                _OrderInterface1 = @interface;

            }
            public ActionResult LoginPage()
            {
                return View();
            }
            [HttpPost]
           

            public ActionResult GetStates(int id)
            {
                dataobj.Configuration.ProxyCreationEnabled = false;
                List<States> states = dataobj.States.Where(x => x.CountryName == id).ToList();
                return Json(states, JsonRequestBehavior.AllowGet);

            }
            public JsonResult Getcity(int id)
            {
                dataobj.Configuration.ProxyCreationEnabled = false;
                List<City> city = dataobj.City.Where(x => x.StateName == id).ToList();
                return Json(city, JsonRequestBehavior.AllowGet);
            }

           
           
            public ActionResult AddProducts()
            {
                ViewBag.Addcoupen = _OrderInterface1.Coupenscode();
                ViewBag.product = _OrderInterface1.Producttableslist();
                ViewBag.orders = _OrderInterface1.orderslist();
                return View();
            }
            [HttpPost]
            public ActionResult AddProducts(Ordermodel ord)
            {
                if (ModelState.IsValid)
                {
                    if (_OrderInterface1.Addorders(ord) == 1)
                    {

                        ViewBag.orders = _OrderInterface1.orderslist();
                        return RedirectToAction("AddProducts", "Home");
                    }
                }
                return View();
            }
            public ActionResult ProductsList()
            {
                return View(_OrderInterface1.orderslist());
            }
            
           

            public ActionResult Edit(int id)
            {
                ViewBag.product = new SelectList(_OrderInterface1.Producttableslist(), "Id", "productName");
                return View(_OrderInterface1.EditOrderd(id));
            }
            [HttpPost]
            public ActionResult Edit(int id, Ordermodel ord)
            {
                if (_OrderInterface1.UpdateOrder(id, ord) == true)
                {
                    return RedirectToAction("ProductsList");
                }
                return View();
            }

            public ActionResult Delete(int id)
            {
                if (_OrderInterface1.DeleteOrder(id) == true)
                {
                    return RedirectToAction("AddProducts");
                }
                return View();

            }
        }
}