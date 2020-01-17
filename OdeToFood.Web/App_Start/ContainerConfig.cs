using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace OdeToFood.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder();

            // get MVCAppliction and register a service
            
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);

            // use InMemoryRestaurantData(Data) whenever someone wants IRestaurantData(interface)
            // SingleInstance is not thread-safe
            // create an instance for every request and discard after using
            builder.RegisterType<SqlRestaurantData>().As<IRestaurantData>().InstancePerRequest();
            builder.RegisterType<OdeToFoodDbContext>().InstancePerRequest();
            var container = builder.Build();

            // For MVC Framework
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            // Web API
            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);

        }
    }
}