using System;
using Scholl_management_WebApplicationmodel.Dbconnection;
using Scholl_management_WebApplicationmodel.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholl_management_WebApplicationHelper.Helper
{
    public class AddCityhelper
    {
        public City Binddata(CityModel model)
        {
            City city = new City();
            city.CountryName = model.CountryName;
            city.StateName = model.StateName;
            city.CityName = model.CityName;
            return city;
        }
        
    }
}
