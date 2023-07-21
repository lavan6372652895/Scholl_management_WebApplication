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
  
    public class CountryServices : CoutryInterface
    {
        public lavan_386Entities1 dtabaseobj = new lavan_386Entities1();
        List<Country> dbCountry = new List<Country>();
        List<Countrymodel> countrymodelslist = new List<Countrymodel>();
        Countryhelper addcountryhelp = new Countryhelper();
        public bool addCountry(Countrymodel countrymodels)
        {
            var result = dtabaseobj.Country.FirstOrDefault(x => x.CountryName == countrymodels.CountryName);
            if (result == null)
            {
                dtabaseobj.sp_AddEditCountry(0,countrymodels.CountryName);
                //dtabaseobj.Country.Add(addcountryhelp.Binddatacountry(countrymodels));
                //dtabaseobj.SaveChanges();
            }
            return true;
        }

        public List<Country> dbcountries()
        {
            return dtabaseobj.Country.ToList();
        }

        public int DeleteCountry(int id)
        {
            var result = dtabaseobj.CountryDelete(id);
            return result;

            
        }

        public Countrymodel EditCountry(int id)
        {
            Countrymodel countrymodelslist = new Countrymodel();
            var result = dtabaseobj.Country.FirstOrDefault(x => x.Id == id);
            
                countrymodelslist.CountryName = result.CountryName;
                return countrymodelslist;
            
            
        }

        public bool UpdateCountry(int id, Countrymodel countrymodels)
        {
            //var result = dtabaseobj.Country.FirstOrDefault(x => x.Id == id);
            //result.CountryName = countrymodels.CountryName;
            //dtabaseobj.SaveChanges();
            dtabaseobj.sp_AddEditCountry(id, countrymodels.CountryName);
            return true;
        }
    }
}
