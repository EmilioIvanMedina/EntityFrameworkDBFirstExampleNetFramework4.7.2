using EntityFrameworkApplication.Interfaces;
using EntityFrameworkInfrastructure.DataBaseModel;
using EntityFrameworkInfrastructure.Repositories;
using EntityFrameworkWebSiteApplication.App_Start;
using EntityFrameworkWebSiteApplication.Controllers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace EntityFrameworkWebSiteApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private IServiceProvider _serviceProvider;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            IServiceCollection services = new ServiceCollection();
            ServicesConfiguration(services);

            _serviceProvider = services.BuildServiceProvider();

            DependencyResolver.SetResolver(new MyDependencyResolver(_serviceProvider));
        }

        private void ServicesConfiguration(IServiceCollection services)
        {
            services.AddTransient<HomeController>();
            services.AddTransient<websitedatabase>();

            services.AddScoped<IContactRepository, ContactRepository>();
        }
    }
}
