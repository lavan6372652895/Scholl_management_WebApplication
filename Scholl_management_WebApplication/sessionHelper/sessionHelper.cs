using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scholl_management_WebApplication.sessionHelper
{
    public class sessionHelper
    {
        public static string Email
        {
            get
            {
                return HttpContext.Current.Session["Email"] == null ? "" : (string)HttpContext.Current.Session["Email"];
            }
            set
            {
                HttpContext.Current.Session["Email"] = value;
            }
        }
        public static string passwordAddress
        {
            get
            {
                return HttpContext.Current.Session["Password"] == null ? "" : (string)HttpContext.Current.Session["Password"];
            }
            set
            {
                HttpContext.Current.Session["Password"] = value;
            }
        }
        public static string Firstname
        {
            get
            {
                return HttpContext.Current.Session["FirstName"] == null ? "" : (string)HttpContext.Current.Session["FirstName"];
            }
            set
            {
                HttpContext.Current.Session["FirstName"] = value;
            }
        }

    }
}