using Newtonsoft.Json;
using PagedList;
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
    public class StatesController : Controller
    {
        public lavan_386Entities1 dtabaseobj = new lavan_386Entities1();
        public StateInterface _stateInterface;
        public StatesController(StateInterface @interface)
        {
            _stateInterface = @interface;
        }
        // GET: States
        public JsonResult GetStatelist()
        {
            
            var states = dtabaseobj.States.ToList();
            var state = JsonConvert.SerializeObject(states);
            return Json(state, JsonRequestBehavior.AllowGet);
        }
        public ActionResult AddState()
        {
            try { 
            ViewBag.countrylist = _stateInterface.droplist();

            return View(); }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public ActionResult AddState(StateModel stateModel)
        {
            try { 
            if (_stateInterface.AddState(stateModel) == true)
            {
                return RedirectToAction("Dashboard", "Home");
            }
            return View();
        }
        catch(Exception ex)
            {
                throw ex;
            }
}
       
        public ActionResult StateList()
        {
            //ViewBag.StateList = _stateInterface.dbstate();
            return View(_stateInterface.dbstate());
        }
        public ActionResult Edit(int id)
        {
            try { 
            ViewBag.countrylist = _stateInterface.droplist();
            return View(_stateInterface.EditState(id));
        }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public ActionResult Edit(int id, StateModel stateModel)
        {
            try
            {
                if (_stateInterface.UpdateState(stateModel, id) == true)
                {
                    return RedirectToAction("StateList");


                }
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public ActionResult Delete(int id)
        {
            try
            {
                _stateInterface.DeleteState(id);
                return RedirectToAction("StateList");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}