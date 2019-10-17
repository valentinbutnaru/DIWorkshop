using DIWorkshop.Interfaces;
using DIWorkshop.Managers;
using DIWorkshop.Persistence;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace DIWorkshop.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

			container.RegisterType<DbContext>();
			container.RegisterType<IDriverRepository, DriverRepository>();
			container.RegisterType<IDriverManager, DriverManager>();
			       
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}