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
    public class StateServices : StateInterface
    {
        lavan_386Entities1 databaseobj = new lavan_386Entities1();
        AdStatesHelper adStatesHelper = new AdStatesHelper();
        public bool AddState(StateModel stateModel)
        {
            try
            {
                databaseobj.States.Add(adStatesHelper.Binddataforstates(stateModel));
                databaseobj.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Statedetails_Result> dbstate()
        {
           

            // Call the stored procedure using the database context or connection
            var results = databaseobj.Database.SqlQuery<Statedetails_Result>("EXEC statedetails").ToList();

            // Return the results as a list of Statedetails_Result objects
            return results;
        }





        //public List<States> dbstate()
        //{
        //    try
        //    {
        //        return databaseobj.States.ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public int DeleteState(int id)
        {
            try
            {
                var result = databaseobj.Sp_Statedele(id);
                return result;
                //var result = databaseobj.States.FirstOrDefault(x => x.Id == id);
                //if(result != null)
                //{
                //    databaseobj.States.Remove(result);
                //    return true;
                //}
                //return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Country> droplist()
        {
            try
            {
                return databaseobj.Country.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public StateModel EditState(int id)
        {
            try
            {
                var result = databaseobj.States.FirstOrDefault(x => x.Id == id);
                StateModel stateModel = new StateModel();
                stateModel.CountryName = result.CountryName;
                stateModel.StateName = result.StateName;
                return (stateModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }



        }

        public bool UpdateState(StateModel stateModel, int id) 
        {
            try
            {
                var result = databaseobj.States.FirstOrDefault(x => x.Id == id);
                result.CountryName = stateModel.CountryName;
                result.StateName = stateModel.StateName;
                databaseobj.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
