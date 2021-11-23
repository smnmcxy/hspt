using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    
    public class Sqlhelper
    {
        private static string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

    }
}
