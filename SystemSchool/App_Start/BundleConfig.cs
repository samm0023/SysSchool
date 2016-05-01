using System.Web;
using System.Web.Optimization;

namespace SystemSchool
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/template").Include(
                        "~/Scripts/angular.js",
                        "~/Scripts/Cuerpo/modulo.js",
                           "~/Scripts/js/Chart.js",
                           "~/Scripts/js/clndr.js",
                           "~/Scripts/js/moment-2.2.1.js",
                           "~/Scripts/js/custom.js",
                           "~/Scripts/js/d3.v3.js",
                           "~/Scripts/js/jquery.min.js",
                           "~/Scripts/js/jquery.vmap.js",
                           "~/Scripts/js/jquery.vmap.sampledata.js",
                           "~/Scripts/js/jquery.vmap.world.js",
                           "~/Scripts/js/metisMenu.min.js",
                           "~/Scripts/js/rickshaw.min.js",
                           "~/Scripts/js/site.min.js",
                           "~/Scripts/js/underscore-min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/template").Include("~/Content/css/bootstrap.min.css",
                "~/Content/css/clndr.css",
                "~/Content/css/custom.css",
                "~/Content/css/font-awesome.css",
                "~/Content/css/jqvmap.css",
                "~/Content/css/lines.css",
                "~/Content/css/style.css"));
           

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}