using Autofac;
using Autofac.Integration.Mvc;
using DIUsingAutofac.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace DIUsingAutofac.App_Start
{
    public static class AutofacConfig
    {
        public static void RegisterContainers()
        {
            var builder = new ContainerBuilder();
            //Register controllers
            builder.RegisterControllers(Assembly.Load("DIUsingAutofac"));
            //Enable parameters injection
            builder.RegisterType<ExtensibleActionInvoker>()
                .As<IActionInvoker>().InjectActionInvoker();
            //Enable property injection for action filter
            builder.RegisterFilterProvider();
            //Register all of dependencies should be injected
            //By default, the scope is instance per dependency
            builder.RegisterType<BlogRepository>().As<IBlogRepository>();
            builder.RegisterType<InstancePerRequest>()
                .As<AbstractInstancePerRequest>().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}