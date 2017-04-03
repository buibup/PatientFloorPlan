using PatientFloorPlan.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientFloorPlan.API.Repository
{
    public interface IPatientFloorPlanRepository
    {
        PatientDrug GetPatientDrug(int epiRowId);
    }
}
