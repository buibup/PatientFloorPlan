using Newtonsoft.Json;
using PatientFloorPlan.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace PatientFloorPlan.MVC.Controllers
{
    public class PatientOrderController : Controller
    {
        // GET: PatientOrder
        public ActionResult Index()
        {
            PatientOrder ptOrder = new PatientOrder();

            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("content-type", "application/json");
                webClient.Encoding = Encoding.UTF8;
                string json = webClient.DownloadString("http://localhost:49250/api/PatientOrder/GetPatientDrug?epiRowId=10");

                ptOrder = JsonConvert.DeserializeObject<PatientOrder>(json);
            }
            ViewData["PatientOrder"] = ptOrder;

            return View();
        }
    }
}