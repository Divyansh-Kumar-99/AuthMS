using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "Web.config", Watch = true)]

namespace AuthenticationApi.Properties
{
    public class AssemblyInfo
    {
    }
}
