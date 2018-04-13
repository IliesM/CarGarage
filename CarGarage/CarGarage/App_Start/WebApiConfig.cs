using CarGarage.Models;
using CarGarage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;
using Unity.Lifetime;

namespace CarGarage
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuration et services API Web

            // Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Services/Dependencies config 

            var container = new UnityContainer();
            container.RegisterType<ICarGarageService<Appointment>, AppointmentService>(new HierarchicalLifetimeManager());
            container.RegisterType<ICarGarageService<Client>, ClientService>(new HierarchicalLifetimeManager());
            container.RegisterType<ICarGarageService<Report>, ReportService>(new HierarchicalLifetimeManager());
            container.RegisterType<ICarGarageService<Worker>, WorkerService>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);
        }
    }
}
