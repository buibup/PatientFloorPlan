using PatientFloorPlan.API.Models;
using PatientFloorPlan.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PatientFloorPlan.API.Controllers
{
    public class DrugController : ApiController
    {
        IPatientFloorPlanRepository repo;
        public PatientDrug GetPatientDrug(int epiRowId)
        {
            repo = new PatientFloorPlanRepository();

            return repo.GetPatientDrug(epiRowId);
        }
    }
}
