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
    public class CityController : Controller
    {
        public lavan_386Entities1 databaseobj = new lavan_386Entities1();
        public CityInterface _cityInterface;
        public CityController(CityInterface @interface)
        {
            _cityInterface = @interface;
        }
       public JsonResult GetCity()
        {
            var result = _cityInterface.Citylist();
            var json = JsonConvert.SerializeObject(result);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetState(int id)
        {
            databaseobj.Configuration.ProxyCreationEnabled = false;
            var result = databaseobj.States.Where(x => x.CountryName == id);
            return Json(result,JsonRequestBehavior.AllowGet);

        }
        
        public ActionResult Index()
        {
            ViewBag.countrylist = databaseobj.Country.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Index(CityModel city)
        {
            if (ModelState.IsValid)
            {
                if (_cityInterface.Addcity(city) == true)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }




    }
}