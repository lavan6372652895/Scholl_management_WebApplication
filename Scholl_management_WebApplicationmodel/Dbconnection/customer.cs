//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Scholl_management_WebApplicationmodel.Dbconnection
{
    using System;
    using System.Collections.Generic;
    
    public partial class customer
    {
        public int customer_id { get; set; }
        public string customer_Name { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public Nullable<int> Country { get; set; }
        public Nullable<int> States { get; set; }
        public Nullable<int> city { get; set; }
        public string Gender { get; set; }
    }
}
