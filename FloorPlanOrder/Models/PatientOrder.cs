using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FloorPlanOrder.Models
{
    public class PatientOrder
    {
        public List<Order> OneDay { get; set; }
        public List<Order> Continue { get; set; }
    }
}