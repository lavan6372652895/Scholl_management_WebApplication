using Scholl_management_WebApplicationmodel.Dbconnection;
using Scholl_management_WebApplicationmodel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholl_management_WebApplicationRepository.Interface
{
    public interface LoginInterface
    {
        int UserLogin(LoginModel loginModel);
        bool Addusers(CreateuserModel reg);
        List<Adduser> dblist();
        bool deleteUser(int id);
    }
}
