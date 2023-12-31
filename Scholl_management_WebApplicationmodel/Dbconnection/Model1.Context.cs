﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class lavan_386Entities1 : DbContext
    {
        public lavan_386Entities1()
            : base("name=lavan_386Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adduser> Adduser { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Producttable> Producttable { get; set; }
        public virtual DbSet<coupen> coupen { get; set; }
        public virtual DbSet<customer> customer { get; set; }
        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
    
        public virtual int CountryDelete(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CountryDelete", idParameter);
        }
    
        public virtual int Sp_Statedele(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Statedele", idParameter);
        }
    
        public virtual int sp_AddEditCountry(Nullable<int> id, string country_name)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var country_nameParameter = country_name != null ?
                new ObjectParameter("country_name", country_name) :
                new ObjectParameter("country_name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddEditCountry", idParameter, country_nameParameter);
        }
    
        public virtual ObjectResult<Statedetails_Result> Statedetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Statedetails_Result>("Statedetails");
        }
    
        public virtual int AddProducttable(Nullable<int> productName, Nullable<int> qnt)
        {
            var productNameParameter = productName.HasValue ?
                new ObjectParameter("ProductName", productName) :
                new ObjectParameter("ProductName", typeof(int));
    
            var qntParameter = qnt.HasValue ?
                new ObjectParameter("qnt", qnt) :
                new ObjectParameter("qnt", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddProducttable", productNameParameter, qntParameter);
        }
    
        public virtual int updateorders(Nullable<int> id, Nullable<int> productName, Nullable<int> qnt)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var productNameParameter = productName.HasValue ?
                new ObjectParameter("ProductName", productName) :
                new ObjectParameter("ProductName", typeof(int));
    
            var qntParameter = qnt.HasValue ?
                new ObjectParameter("qnt", qnt) :
                new ObjectParameter("qnt", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateorders", idParameter, productNameParameter, qntParameter);
        }
    
        public virtual int AddEditcity(Nullable<int> id, string cityname, Nullable<int> stateid, Nullable<int> country)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var citynameParameter = cityname != null ?
                new ObjectParameter("cityname", cityname) :
                new ObjectParameter("cityname", typeof(string));
    
            var stateidParameter = stateid.HasValue ?
                new ObjectParameter("stateid", stateid) :
                new ObjectParameter("stateid", typeof(int));
    
            var countryParameter = country.HasValue ?
                new ObjectParameter("country", country) :
                new ObjectParameter("country", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddEditcity", idParameter, citynameParameter, stateidParameter, countryParameter);
        }
    }
}
