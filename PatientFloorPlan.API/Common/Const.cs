using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace PatientFloorPlan.API.Common
{
    public class Const
    {
        public static string Cache89 = ConfigurationManager.ConnectionStrings["Cache89"].ToString();
        public static string Cache47 = ConfigurationManager.ConnectionStrings["Cache47"].ToString();
        public static string Cache49 = ConfigurationManager.ConnectionStrings["Cache49"].ToString();
    }
}