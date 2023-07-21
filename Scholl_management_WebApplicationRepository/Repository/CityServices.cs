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
    public class CityServices : CityInterface
    {
        lavan_386Entities1 databaseobj = new lavan_386Entities1();
        AddCityhelper cityhelper = new AddCityhelper();

        public bool Addcity(CityModel city)
        {
            databaseobj.AddEditcity(null, city.CityName, city.StateName, city.CountryName);
            return true;
        }

        public List<City> Citylist()
        {
            return databaseobj.City.ToList();
        }
    }
}
