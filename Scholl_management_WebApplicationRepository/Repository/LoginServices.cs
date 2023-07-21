using Scholl_management_WebApplicationHelper.Helper;
using Scholl_management_WebApplicationmodel.Dbconnection;
using Scholl_management_WebApplicationmodel.Model;
using Scholl_management_WebApplicationRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholl_management_WebApplicationRepository.Repository
{
    public class LoginServices : LoginInterface
    {
        public lavan_386Entities1 dtabaseobj = new lavan_386Entities1();
        public static List<Adduser> Adduserlist = new List<Adduser>();
        public static List<CreateuserModel> CreateuserModellist = new List<CreateuserModel>();
        AdduserHelper helpero = new AdduserHelper();

        public int UserLogin(LoginModel loginModel)
        {
            var result = dtabaseobj.Adduser.Where(x => x.Email == loginModel.Email && x.Password == loginModel.password);
            if(result.Count()!=0)
            {
                return 1;
            }
            return 0;
        }

        public bool Addusers(CreateuserModel reg)
        {
            dtabaseobj.Adduser.Add(helpero.Binddata(reg));
            dtabaseobj.SaveChanges();
            return true;
            
        }

        public List<Adduser> dblist()
        {
            return dtabaseobj.Adduser.ToList();
        }

        public bool deleteUser(int id)
        {
            var result = dtabaseobj.Adduser.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                dtabaseobj.Adduser.Remove(result);
                dtabaseobj.SaveChanges();
                return true;
            }
            return false;
        }
    }
   
    
}
