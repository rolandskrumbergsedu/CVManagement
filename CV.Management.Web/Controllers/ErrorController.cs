using CV.Management.Web.Models;
using Microsoft.ApplicationInsights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Management.Web.Controllers
{
    public class ErrorController : Controller
    {
        private readonly TelemetryClient _telemetry = new TelemetryClient();

        [HttpGet]
        public ViewResult Index()
        {
            _telemetry.TrackPageView("ErrorPage");

            var traceId = Guid.NewGuid().ToString();

            _telemetry.TrackEvent("ErrorPage", new Dictionary<string, string> { { "TraceId", traceId } });

            var viewModel = new ErrorViewModel
            {
                TraceId = traceId
            };

            return View(viewModel);
        }

        [HttpGet]
        public ViewResult NotFound()
        {
            _telemetry.TrackPageView("NotFound");

            return View("NotFound");
        }
    }
}