using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.ApplicationInsights;
using System.Collections;
using vmss_demo.Models;

namespace vmss_demo.Controllers
{
    public class HomeController : Controller
    {
        private TelemetryClient telemetry = new TelemetryClient();

        public ActionResult Index()
        {
            telemetry.TrackEvent("vmss-demo:homepage");
            ViewBag.MachineName = System.Environment.MachineName;
            return View();
        }

        public ActionResult Test()
        {
            telemetry.TrackEvent("vmss-demo:testpage");
            ViewBag.MachineName = System.Environment.MachineName;
            return View();
        }

        public ActionResult Environment()
        {
            telemetry.TrackEvent("vmss-demo:environmentpage");
            ViewBag.MachineName = System.Environment.MachineName;
            ServerEnvironmentViewModel sevm = new ServerEnvironmentViewModel();
            return View(sevm);
        }

    }
}