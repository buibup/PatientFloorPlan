using PatientFloorPlan.API.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PatientFloorPlan.API.Common
{
    public class Helper
    {
       public static PatientOrder DataTableToPatientOrder(DataTable dtOneDay, DataTable dtContinue)
        {
            PatientOrder ptOrder = new PatientOrder();
            
            List<Order> orderOneDayList = new List<Order>();
            List<Order> orderContinueList = new List<Order>();

            foreach (DataRow row in dtOneDay.Rows)
            {
                Order orderOneDay = new Order();
                orderOneDay.ARCIM_Desc = row["ARCIM_Desc"].ToString();
                orderOneDay.OEORI_PhQtyOrd = Convert.ToDecimal(row["OEORI_PhQtyOrd"].ToString());
                orderOneDay.CTUOM_Code = row["CTUOM_Code"].ToString();
                orderOneDay.PHCIN_Desc1 = row["PHCIN_Desc1"].ToString();
                orderOneDayList.Add(orderOneDay);
            }

            foreach (DataRow row in dtContinue.Rows)
            {
                Order orderContinue = new Order();
                orderContinue.ARCIM_Desc = row["ARCIM_Desc"].ToString();
                orderContinue.OEORI_PhQtyOrd = Convert.ToDecimal(row["OEORI_PhQtyOrd"].ToString());
                orderContinue.CTUOM_Code = row["CTUOM_Code"].ToString();
                orderContinue.PHCIN_Desc1 = row["PHCIN_Desc1"].ToString();
                orderContinueList.Add(orderContinue);
            }

            ptOrder.OneDay = orderOneDayList;
            ptOrder.Continue = orderContinueList;

            return ptOrder;
        }
    }
}