using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientFloorPlan.API.Models
{
    public class PatientDrug
    {
        public int EpiRowId { get; set; }
        public List<Drug> DrugListOneDay { get; set; }
        public List<Drug> DrugListContinue { get; set; }
    }
}