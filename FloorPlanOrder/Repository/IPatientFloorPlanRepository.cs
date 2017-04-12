using FloorPlanOrder.Models;

namespace FloorPlan.API.Repository
{
    public interface IFloorPlanRepository
    {
        PatientOrder GetPatientOrder(string epiRowId);
    }
}
