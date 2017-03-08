using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIUsingAutofac.Domain
{
    public class BlogRepository : IBlogRepository
    {
        public string GetWebsite()
        {
            return "DrunkCoding";
        }
    }
}