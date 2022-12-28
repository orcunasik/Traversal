using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.Repository
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Traversal.Mvc"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("SqlConnection");
            }
        }
    }
}
