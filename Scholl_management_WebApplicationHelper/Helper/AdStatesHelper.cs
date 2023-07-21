using Scholl_management_WebApplicationmodel.Dbconnection;
using Scholl_management_WebApplicationmodel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholl_management_WebApplicationHelper.Helper
{
   public  class AdStatesHelper
    {
        public States Binddataforstates(StateModel stateModel)
        {
            States objstates = new States();
            objstates.CountryName = stateModel.CountryName;
            objstates.StateName = stateModel.StateName;
            return objstates;

        }
    }
}
