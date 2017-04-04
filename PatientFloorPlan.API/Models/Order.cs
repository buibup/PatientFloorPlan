using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientFloorPlan.API.Models
{
    public class Order
    {
        public string ARCIM_Desc { get; set; }
        public decimal OEORI_PhQtyOrd { get; set; }
        public string CTUOM_Code { get; set; }
        public string PHCIN_Desc1 { get; set; }
    }
}