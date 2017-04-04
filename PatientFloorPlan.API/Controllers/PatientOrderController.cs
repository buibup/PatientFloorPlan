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
    public class PatientOrderController : ApiController
    {
        IPatientFloorPlanRepository repo;
        public IHttpActionResult GetPatientDrug(string epiRowId)
        {
            repo = new PatientFloorPlanRepository();

            var ptOrder = repo.GetPatientOrder(epiRowId);

            if(ptOrder == null)
            {
                return Content(HttpStatusCode.NotFound, "Data not found.");
            }

            return Json(ptOrder);
        }
    }
}
