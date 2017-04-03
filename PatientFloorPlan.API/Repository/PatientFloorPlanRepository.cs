using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PatientFloorPlan.API.Models;

namespace PatientFloorPlan.API.Repository
{
    public class PatientFloorPlanRepository : IPatientFloorPlanRepository
    {

        static List<Drug> drugsOneDay = new List<Drug>
            {
                new Drug { Name = "Ciprofloxacin",  Unit = "mg", Volume = 1 },
                new Drug { Name = "Ibuprofen",  Unit = "mg", Volume = 1 },
                new Drug { Name = "Naproxen",  Unit = "mg", Volume = 1 },
                new Drug { Name = "Zoloft",  Unit = "mg", Volume = 1 },
                new Drug { Name = "Xanax",  Unit = "mg", Volume = 1 },
                new Drug { Name = "Metoprolol",  Unit = "mg", Volume = 1 },
                new Drug { Name = "Hydrochlorothiazide",  Unit = "mg", Volume = 1 }
            };
        static List<Drug> drugsContinue = new List<Drug>
            {
                new Drug { Name = "Acetaminophen",  Unit = "mg", Volume = 1 },
                new Drug { Name = "Citalopram",  Unit = "mg", Volume = 1 },
                new Drug { Name = "Lexapro",  Unit = "mg", Volume = 1 },
                new Drug { Name = "Omeprazole",  Unit = "mg", Volume = 1 },
                new Drug { Name = "Alprazolam",  Unit = "mg", Volume = 1 },
                new Drug { Name = "Amlodipine",  Unit = "mg", Volume = 1 },
                new Drug { Name = "Ativan",  Unit = "mg", Volume = 1 }
            };

        static List<PatientDrug> ptdrugList = new List<PatientDrug>
        {
            new PatientDrug { EpiRowId = 1234, DrugListOneDay = drugsOneDay, DrugListContinue = drugsContinue },
            new PatientDrug { EpiRowId = 2222, DrugListOneDay = drugsOneDay, DrugListContinue = drugsContinue },
            new PatientDrug { EpiRowId = 1111, DrugListOneDay = drugsOneDay, DrugListContinue = drugsContinue },
            new PatientDrug { EpiRowId = 4444, DrugListOneDay = drugsOneDay, DrugListContinue = drugsContinue },
            new PatientDrug { EpiRowId = 3333, DrugListOneDay = drugsOneDay, DrugListContinue = drugsContinue },
            new PatientDrug { EpiRowId = 5555, DrugListOneDay = drugsOneDay, DrugListContinue = drugsContinue },
        };

        public PatientDrug GetPatientDrug(int epiRowId)
        {
            return ptdrugList.Single(ptd => ptd.EpiRowId == epiRowId);
        }
    }
}

