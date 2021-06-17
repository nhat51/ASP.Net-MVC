using System.Web;
using System.Web.Optimization;

namespace Lab1
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            /*bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
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
                      "~/Content/site.css"));*/
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/plugins/fontawesome-free/css/all.min.css",
                      "~/Content/dist/css/adminlte.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/plugins/jquery/jquery.min.js",
                        "~/Scripts/plugins/bootstrap/js/bootstrap.bundle.min.js",
                        "~/Scripts/dist/js/adminlte.min.js",
                        "~/Scripts/dist/js/demo.js"));
        }
    }
}
