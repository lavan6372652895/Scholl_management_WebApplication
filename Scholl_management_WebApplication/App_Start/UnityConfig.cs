using Scholl_management_WebApplicationRepository.Interface;
using Scholl_management_WebApplicationRepository.Repository;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Scholl_management_WebApplication
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<LoginInterface, LoginServices>();
            container.RegisterType<CoutryInterface, CountryServices>();
            container.RegisterType<StateInterface, StateServices>();
            container.RegisterType<CityInterface, CityServices>();
            container.RegisterType<OrderInterface1, OrderServices>();
            container.RegisterType<customerinterface, CustomerServices>();
        }
    }
}