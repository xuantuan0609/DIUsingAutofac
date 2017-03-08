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
            builder.RegisterControllers(Assembly.Load("DIUsingAutofac"));
                        builder.RegisterType<ExtensibleActionInvoker>().As<IActionInvoker>().InjectActionInvoker();
            builder.RegisterType<BlogRepository>().As<IBlogRepository>();
            builder.RegisterType<InstancePerRequest>().As<IInstancePerRequest>().InstancePerRequest();
            
            builder.RegisterFilterProvider();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}