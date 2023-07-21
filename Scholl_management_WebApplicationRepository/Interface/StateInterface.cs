using Scholl_management_WebApplicationmodel.Dbconnection;
using Scholl_management_WebApplicationmodel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholl_management_WebApplicationRepository.Interface
{
    public interface StateInterface
    {
        bool AddState(StateModel stateModel);
        List<Country> droplist();
        //List<States> dbstate();
        List<Statedetails_Result> dbstate();
        StateModel EditState(int id);
        bool UpdateState(StateModel stateModel, int id);
        int DeleteState(int id);
    }
}
