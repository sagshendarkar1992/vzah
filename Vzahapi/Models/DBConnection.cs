using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Routecardapi.Models
{
    public class DBConnection
    {
        public static string GetConnectionString = ConfigurationManager.ConnectionStrings["Connection String"].ConnectionString;

    }
}