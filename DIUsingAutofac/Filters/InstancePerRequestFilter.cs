using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DIUsingAutofac.Domain;

namespace DIUsingAutofac.Filters
{
    public class InstancePerRequestFilter: ActionFilterAttribute
    {
        public AbstractInstancePerRequest Instance { get; set; }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Instance.Text = "Demo Instance Per Request";
        }
    }
}