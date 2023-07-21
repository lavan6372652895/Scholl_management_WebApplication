
using Scholl_management_WebApplicationmodel.Model;
using Scholl_management_WebApplicationRepository.Interface;
using System;
using Scholl_management_WebApplication.sessionHelper;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Web.Security;

namespace Scholl_management_WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public LoginInterface _LoginInterface;
            public HomeController(LoginInterface loginte)
        {
            _LoginInterface = loginte;
            }
        public ActionResult Loginpage()
        {

            return View();
        }

      /*  [Actionfilter]*/
        [HttpPost]
        public ActionResult Loginpage(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (_LoginInterface.UserLogin(loginModel) == 1)
                    {
                        Session["Email"] = loginModel.Email;
                        sessionHelper.sessionHelper.Email = loginModel.Email;

                        return RedirectToAction("dashboard");

                    }
                }
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ActionResult Adduserpage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Adduserpage(CreateuserModel createuser)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _LoginInterface.Addusers(createuser);
                    if (result == true)
                    {
                        return RedirectToAction("dashboard");
                    }
                }
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Actionfilter]
        public ActionResult dashboard()
        {
            return View();
        }
        public ActionResult Tablelist()
        {
            try
            {
                return View(_LoginInterface.dblist());
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
                if (_LoginInterface.deleteUser(id) == true)
                {
                    return RedirectToAction("Tablelist");
                }
                return RedirectToAction("Tablelist");
            }
            catch(Exception ex){
                throw ex;
            }

        }

    }
}