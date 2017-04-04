using PatientFloorPlan.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientFloorPlan.API.DA
{
    public class PatientFloorPlanQueryString
    {
        public static string GetPatientOrder(string epiRowId, string type)
        {
            string OECPR_Desc = string.Empty;
            
            switch (type.ToString().ToUpper())
            {
                case "ONEDAY":
                    OECPR_Desc = "Normal";
                    break;
                case "CONTINUE":
                    OECPR_Desc = "Standing";
                    break;
                default:
                    break;
            }

            string queryString = @"

            SELECT distinct OE_OrdItem->OEORI_SttDat
                , OE_OrdItem->OEORI_SttTim
                , OE_OrdItem->OEORI_PrescSeqNo
                , OE_OrdItem->OEORI_PrescNo
                , OE_OrdItem->OEORI_RowId
                , OEORD_Date,OEORD_Time
                , OE_OrdItem->OEORI_ItmMast_DR->ARCIM_Desc
                , OE_OrdItem->OEORI_PhQtyOrd
                , OE_OrdItem->OEORI_Unit_DR->CTUOM_Code
                , OE_OrdItem->OEORI_Instr_DR->PHCIN_Desc1  
            FROM OE_Order where OEORD_Adm_DR->PAADM_Rowid={epiRowId} 
            and OE_OrdItem->OEORI_ItemStat_DR->OSTAT_Desc <>'D/C (Discontinued)' 
            and OE_OrdItem->OEORI_Priority_DR->OECPR_Desc='{OECPR_Desc}' 
            and OE_OrdItem->OEORI_ItmMast_DR->ARCIM_ItemCat_DR->ARCIC_OrdCat_DR->ORCAT_Desc='Medicine' 
            order by OE_OrdItem->OEORI_SttDat desc ,OE_OrdItem->OEORI_PrescNo desc

            ";

            queryString = queryString.Replace("{epiRowId}", epiRowId);
            queryString = queryString.Replace("{OECPR_Desc}", OECPR_Desc);

            return queryString;
        }
        
    }
}