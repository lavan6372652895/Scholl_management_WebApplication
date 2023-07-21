using Newtonsoft.Json;
using Scholl_management_WebApplicationmodel.Dbconnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scholl_management_WebApplication.Controllers
{
    public class QuizController  : Controller
    {
        lavan_386Entities1 db = new lavan_386Entities1();
        // GET: Quiz
        public JsonResult GetQuestion(int id)
        {
            var que = db.Questions.Where(x => x.id == id).ToList();
            var ques = JsonConvert.SerializeObject(que);
            return Json(ques, JsonRequestBehavior.AllowGet);
        }
        public ActionResult QuizPage()
        {
            
            return View();
        }
        
    }
}