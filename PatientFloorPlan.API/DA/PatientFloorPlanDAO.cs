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

        public static PatientOrder GetPatientOrderTest(string epiRowId)
        {
            PatientOrder ptOrder = new PatientOrder();

            List<Order> orderOneDay = new List<Order>
            {
                new Order { ARCIM_Desc = "testO1", CTUOM_Code = "test1", OEORI_PhQtyOrd = 1, PHCIN_Desc1 = "test1" },
                new Order { ARCIM_Desc = "testO2", CTUOM_Code = "test2", OEORI_PhQtyOrd = 1, PHCIN_Desc1 = "test2" },
                new Order { ARCIM_Desc = "testO3", CTUOM_Code = "test3", OEORI_PhQtyOrd = 1, PHCIN_Desc1 = "test3" }
            };

            List<Order> orderContinue = new List<Order>
            {
                new Order { ARCIM_Desc = "testC1", CTUOM_Code = "test1", OEORI_PhQtyOrd = 1, PHCIN_Desc1 = "test1" },
                new Order { ARCIM_Desc = "testC2", CTUOM_Code = "test2", OEORI_PhQtyOrd = 1, PHCIN_Desc1 = "test2" },
                new Order { ARCIM_Desc = "testC3", CTUOM_Code = "test3", OEORI_PhQtyOrd = 1, PHCIN_Desc1 = "test3" }
            };

            ptOrder.OneDay = orderOneDay;
            ptOrder.Continue = orderContinue;

            return ptOrder;
        }
    }
}