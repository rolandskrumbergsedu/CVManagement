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
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/legacy/style").Include(
                      "~/Content/Legacy/style.css"));

            bundles.Add(new StyleBundle("~/legacy/croppie").Include(
                      "~/Content/Legacy/croppie.css"));

            bundles.Add(new StyleBundle("~/legacy/bootstrap-datepicker").Include(
                      "~/Content/Legacy/bootstrap-datetimepicker.min.css"));

            bundles.Add(new ScriptBundle("~/legacy/jquery").Include(
                "~/Content/Legacy/js/vendor/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/legacy/moment").Include(
                "~/Content/Legacy/js/vendor/moment.js"));

            bundles.Add(new ScriptBundle("~/legacy/bootstrap").Include(
                "~/Content/Legacy/js/vendor/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/legacy/bootstrap-datepicker").Include(
               "~/Content/Legacy/js/vendor/bootstrap-datetimepicker.min.js"));

            bundles.Add(new ScriptBundle("~/legacy/jquery-scrollbar").Include(
               "~/Content/Legacy/js/vendor/jquery.mCustomScrollbar.concat.min.js"));

            bundles.Add(new ScriptBundle("~/legacy/jquery-mask").Include(
               "~/Content/Legacy/js/jquery.mask.js"));

            bundles.Add(new ScriptBundle("~/legacy/autosize").Include(
               "~/Content/Legacy/js/autosize.js"));

            bundles.Add(new ScriptBundle("~/legacy/croppie").Include(
               "~/Content/Legacy/js/croppie.js"));
        }
    }
}
