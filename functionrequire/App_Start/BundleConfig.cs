using System.Web;
using System.Web.Optimization;

namespace functionrequire
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

            bundles.Add(new ScriptBundle("~/bundles/assets").Include(
               "~/Content/assets/js/backend-bundle.min.js",
               "~/Content/assets/js/customizer.js",
               "~/Content/assets/js/app.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/assets/css/backend.min.css",
                      "~/Content/assets/vendor/@fortawesome/fontawesome-free/css/all.min.css",
                      "~/Content/assets/vendor/line-awesome/dist/line-awesome/css/line-awesome.min.css",
                      "~/Content/assets/vendor/remixicon/fonts/remixicon.css",
                      "~/Content/Chat.css"));
        }
    }
}
