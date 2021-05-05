using System.Web;
using System.Web.Optimization;

namespace DnD___Campaign_Dashboard_v._1
{
    public class BundleConfig
    {
        // Bundling allows you to collate commonly used files together so they can be bulk accessed
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Bundles the necessary files required for jQuery together, DataTables is included in this as it is an extension of jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/DataTables/jquery.datatables.js",
                        "~/Scripts/DataTables/datatables.bootstrap.js"));

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
                      "~/Content/Site.css",
                      "~/Content/DataTables/css/datatables.bootstrap.css"));
        }
    }
}
