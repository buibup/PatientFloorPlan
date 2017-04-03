using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientFloorPlan.API.Models
{
    public class Drug
    {
        public string Name { get; set; }
        public int Volume { get; set; }
        public string Unit { get; set; }
    }
}