using Scholl_management_WebApplicationmodel.Dbconnection;
using Scholl_management_WebApplicationmodel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholl_management_WebApplicationHelper.Helper
{
    public class AdduserHelper
    {
        public Adduser Binddata(CreateuserModel newuser)
        {
            Adduser addusers = new Adduser();
            addusers.FirstName = newuser.FirstName;
            addusers.LastName = newuser.LatName;
            addusers.Email = newuser.Mail;
            addusers.Password = newuser.password;
            addusers.BranchName = newuser.Branch;
            return addusers;
        }
    }
}
