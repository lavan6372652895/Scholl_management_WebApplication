using Scholl_management_WebApplicationmodel.Model;
using Scholl_management_WebApplicationRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace Scholl_management_WebApplication.Controllers
{
    public class CountryController : Controller
    {
        public CoutryInterface _CoutryInterface;
        public CountryController(CoutryInterface coutryInterface)
        {
            _CoutryInterface = coutryInterface;
        }

        // GET: Country
        public ActionResult AddCountry()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCountry(Countrymodel countrymodels)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (_CoutryInterface.addCountry(countrymodels) == true)
                    {
                        return RedirectToAction("CountryList");
                    }
                }
                return View();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public ActionResult CountryList(int ? id)
        {
            try
            {
                return View(_CoutryInterface.dbcountries().ToPagedList(id ?? 1,3));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public ActionResult Delete(int id)
        {
            try
            {
                _CoutryInterface.DeleteCountry(id);

                return RedirectToAction("CountryList");
            }
            catch(Exception ex)
            {
                throw ex;
            }
         
        }
        public ActionResult Edit(int id)
        {
            try
            {
                return View(_CoutryInterface.EditCountry(id));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public ActionResult Edit(int id, Countrymodel countrymodels)
        {
            try { 
            if (_CoutryInterface.UpdateCountry(id, countrymodels))
            {

                return RedirectToAction("CountryList");
            }
            return View();
        }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
