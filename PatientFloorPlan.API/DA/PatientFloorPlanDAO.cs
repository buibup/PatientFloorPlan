using InterSystems.Data.CacheClient;
using PatientFloorPlan.API.Common;
using PatientFloorPlan.API.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace PatientFloorPlan.API.DA
{
    public static class PatientFloorPlanDAO
    {
        private static string conString = Const.Cache47;
        public static PatientOrder GetPatientOrder(string epiRowId)
        {
            PatientOrder ptOrder = new PatientOrder();

            var dtOneDay = InterSystemsDA.DTBindDataCommand(PatientFloorPlanQueryString.GetPatientOrder(epiRowId, "OneDay"), conString);
            var dtContinue = InterSystemsDA.DTBindDataCommand(PatientFloorPlanQueryString.GetPatientOrder(epiRowId, "Continue"), conString);

            ptOrder = Helper.DataTableToPatientOrder(dtOneDay, dtContinue);

            return ptOrder;
        }
    }
}