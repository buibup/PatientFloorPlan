using FloorPlan.API.Repository;
using FloorPlanOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FloorPlanOrder.Controllers
{
    public class FloorPlanOrderController : Controller
    {
        string epiRowId = string.Empty;
        IFloorPlanRepository repo;
        public ActionResult Index()
        {
            PatientOrder ptOrder = new PatientOrder();
            HttpCookie lastEpiRowId = new HttpCookie("EpiRowId");
            repo = new FloorPlanRepository();

            if (Request.QueryString["epiRowId"] != null)
            {
                epiRowId = Request.QueryString["epiRowId"];
                lastEpiRowId["lastEpiRowId"] = epiRowId;
                lastEpiRowId.Expires = DateTime.Now.AddHours(1);
                Response.Cookies.Add(lastEpiRowId);
            }

            if (string.IsNullOrEmpty(epiRowId))
            {

                if (Request.Cookies["EpiRowId"] == null)
                {
                    return View();
                }

                epiRowId = Request.Cookies["EpiRowId"]["lastEpiRowId"];
            }

            ptOrder = repo.GetPatientOrder(epiRowId);

            ViewData["PatientOrder"] = ptOrder;

            return View();
        }
    }
}