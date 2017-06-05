using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.ApplicationInsights;

namespace vmss_demo.Controllers
{
    public class HomeController : Controller
    {
        private TelemetryClient telemetry = new TelemetryClient();
        public ActionResult Index()
        {
            telemetry.TrackEvent("vmss-demo:homepage");
            return View();
        }

        public ActionResult Test()
        {
            telemetry.TrackEvent("vmss-demo:testpage");
           

            return View();
        }

      
    }
}