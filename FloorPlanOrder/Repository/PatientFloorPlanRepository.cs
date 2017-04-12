using FloorPlan.API.DA;
using FloorPlanOrder.Models;

namespace FloorPlan.API.Repository
{
    public class FloorPlanRepository : IFloorPlanRepository
    {

        public PatientOrder GetPatientOrder(string epiRowId)
        {
            //var ptOrder = PatientFloorPlanDAO.GetPatientOrderTest(epiRowId);

            return PatientFloorPlanDAO.GetPatientOrder(epiRowId);
        }
    }
}

