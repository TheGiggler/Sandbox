using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CollectionJson.Client;
using CollectionJson;
using WebApiSandbox.Models;
using Autofac;
using Autofac.Integration.WebApi;
using WebApiSandbox.Infrastructure;

namespace WebApiSandbox
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            var builder = new ContainerBuilder();
            builder.RegisterType<UserDocumentWriter>().As<ICollectionJsonDocumentWriter<User>>();
            builder.RegisterType<UserDocumentReader>().As<ICollectionJsonDocumentReader<User>>();
            builder.RegisterType<WriteDocument>().As<IWriteDocument>();
            builder.RegisterApiControllers(typeof(WebApiSandbox.Controllers.UsersController).Assembly);
            builder.RegisterHttpRequestMessage(config);

            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);

            config.DependencyResolver = resolver;


        }
    }
}
