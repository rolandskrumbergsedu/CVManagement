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
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/main.css"));

            bundles.Add(new StyleBundle("~/legacy/css/style").Include(
                      "~/Content/Legacy/style.css"));

            bundles.Add(new StyleBundle("~/legacy/css/croppie").Include(
                      "~/Content/Legacy/croppie.css"));

            bundles.Add(new StyleBundle("~/legacy/css/bootstrap-datepicker").Include(
                      "~/Content/Legacy/bootstrap-datetimepicker.min.css"));

            bundles.Add(new ScriptBundle("~/legacy/js/jquery").Include(
                "~/Content/Legacy/js/vendor/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/legacy/js/moment").Include(
                "~/Content/Legacy/js/vendor/moment.js"));

            bundles.Add(new ScriptBundle("~/legacy/js/bootstrap").Include(
                "~/Content/Legacy/js/vendor/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/legacy/js/bootstrap-datepicker").Include(
               "~/Content/Legacy/js/vendor/bootstrap-datetimepicker.min.js"));

            bundles.Add(new ScriptBundle("~/legacy/js/jquery-scrollbar").Include(
               "~/Content/Legacy/js/vendor/jquery.mCustomScrollbar.concat.min.js"));

            bundles.Add(new ScriptBundle("~/legacy/js/jquery-mask").Include(
               "~/Content/Legacy/js/jquery.mask.js"));

            bundles.Add(new ScriptBundle("~/legacy/js/autosize").Include(
               "~/Content/Legacy/js/autosize.js"));

            bundles.Add(new ScriptBundle("~/legacy/js/croppie").Include(
               "~/Content/Legacy/js/croppie.js"));
        }
    }
}
