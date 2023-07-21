using Scholl_management_WebApplicationmodel.Dbconnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholl_management_WebApplicationmodel.Model
{
    public class Quizmodel
    {
        public List<Questions> questionslist { get; set; }
        public List<Answers> Answerslist { get; set; }
    }
}
