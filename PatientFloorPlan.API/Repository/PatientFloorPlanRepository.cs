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
            // test
            PatientOrder ptOrder = new PatientOrder();

            List<Order> orderOneDay = new List<Order>
            {
                new Order { ARCIM_Desc = "เทส1", CTUOM_Code = "test1", OEORI_PhQtyOrd = 1, PHCIN_Desc1 = "ใส่ใจ" },
                new Order { ARCIM_Desc = "testO2", CTUOM_Code = "test2", OEORI_PhQtyOrd = 1, PHCIN_Desc1 = "test2" },
                new Order { ARCIM_Desc = "testO3", CTUOM_Code = "test3", OEORI_PhQtyOrd = 1, PHCIN_Desc1 = "test3" }
            };

            List<Order> orderContinue = new List<Order>
            {
                new Order { ARCIM_Desc = "testC1", CTUOM_Code = "test1", OEORI_PhQtyOrd = 1, PHCIN_Desc1 = "test1" },
                new Order { ARCIM_Desc = "testC2", CTUOM_Code = "test2", OEORI_PhQtyOrd = 1, PHCIN_Desc1 = "test2" },
                new Order { ARCIM_Desc = "เทส3", CTUOM_Code = "test3", OEORI_PhQtyOrd = 1, PHCIN_Desc1 = "test3" }
            };

            ptOrder.OneDay = orderOneDay;
            ptOrder.Continue = orderContinue;


            return ptOrder;

            //return PatientFloorPlanDAO.GetPatientOrder(epiRowId);
        }
    }
}

