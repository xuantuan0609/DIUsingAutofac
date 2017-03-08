using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIUsingAutofac.Domain
{
    public class InstancePerRequest : IInstancePerRequest
    {
        public string Text { get; set; }
    }
}