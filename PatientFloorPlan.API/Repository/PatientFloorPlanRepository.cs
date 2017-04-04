using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PatientFloorPlan.API.Models;
using PatientFloorPlan.API.DA;

namespace PatientFloorPlan.API.Repository
{
    public class PatientFloorPlanRepository : IPatientFloorPlanRepository
    {
        public PatientOrder GetPatientOrder(string epiRowId)
        {
            return PatientFloorPlanDAO.GetPatientOrder(epiRowId);
        }
    }
}

