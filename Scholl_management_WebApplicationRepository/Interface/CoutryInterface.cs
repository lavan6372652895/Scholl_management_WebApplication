using Scholl_management_WebApplicationmodel.Dbconnection;
using Scholl_management_WebApplicationmodel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholl_management_WebApplicationRepository.Interface
{
    public interface CoutryInterface
    {
        bool addCountry(Countrymodel countrymodels);
        List<Country> dbcountries();
        int DeleteCountry(int id);
        Countrymodel EditCountry(int id);
        bool UpdateCountry(int id, Countrymodel countrymodels);
    }
}
