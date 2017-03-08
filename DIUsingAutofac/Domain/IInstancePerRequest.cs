using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIUsingAutofac.Domain
{
    public interface IInstancePerRequest
    {
        string Text { get; set; }
    }
}
