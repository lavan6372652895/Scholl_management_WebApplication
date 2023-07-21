using Newtonsoft.Json;
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
    public class CustomerController : Controller
    {
        lavan_386Entities1 db = new lavan_386Entities1();
        public customerinterface _customerinterface;
        public CustomerController(customerinterface @interface)
        {
            _customerinterface = @interface;
        }
        public JsonResult GetStates(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var result = db.States.Where(x => x.CountryName == id).ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetCity(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var result = db.City.Where(x => x.StateName == id).ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
       public JsonResult Getcustomer()
        {
            var result = _customerinterface.dblist();
            var res = JsonConvert.SerializeObject(result);
            return Json(res, JsonRequestBehavior.AllowGet);
        }
        public ActionResult AddCustomer()
        {
            ViewBag.Country = db.Country.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(CustomerModel customer)
        {
            if (ModelState.IsValid)
            {
                if (_customerinterface.AddNewCustomer(customer) == 1)
                {
                    return RedirectToAction("AddCustomer");
                }
                else
                {
                    TempData["Emai"] = "Email already exist";
                    return View();
                }
      
            }
            return View();
        }
    }
}