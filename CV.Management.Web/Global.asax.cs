using Microsoft.ApplicationInsights;
using Microsoft.Extensions.Logging;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CV.Management.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration.Active.InstrumentationKey = System.Web.Configuration.WebConfigurationManager.AppSettings["InstrumentationKey"];

            MvcHandler.DisableMvcResponseHeader = true;

        }

        protected void Application_Error()
        {
            var exception = Server.GetLastError();

            var telemetry = new TelemetryClient();

            telemetry.TrackException(exception);
        }

        protected void Application_EndRequest()
        {
            Response.Headers.Remove("Server");
        }
    }
}
