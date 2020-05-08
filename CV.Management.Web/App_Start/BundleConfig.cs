using System.Web;
using System.Web.Optimization;

namespace CV.Management.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*",
                    "~/Scripts/jquery.unobtrusive*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/navigation-bar.css",
                      "~/Content/education.css",
                      "~/Content/login.css",
                      "~/Content/panel.css",
                      "~/Content/personal-information.css",
                      "~/Content/popup.css",
                      "~/Content/admin.css",
                      "~/Content/main.css"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/app.js"));

#if DEBUG
            BundleTable.EnableOptimizations = false;
#else
        BundleTable.EnableOptimizations = true;
#endif
        }
    }
}
