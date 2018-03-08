using System.Web;
using System.Web.Optimization;

namespace CooKHouseProject1
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/LoginJs").Include(
                   "~/Scripts/LoginJS/*.js"));


            bundles.Add(new ScriptBundle("~/bundles/IndexTemplate").Include(
                        "~/Scripts/IndexScripts/*.js",
                      "~/Scripts/IndexScripts/jquery.min.js" ));



            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));



            bundles.Add(new StyleBundle("~/bundles/TempalteCss").Include(
                      "~/Content/TemplateCss/*.css"));

            bundles.Add(new StyleBundle("~/Content/loginCss").Include(
                      "~/Content/loginCss/style.css",
                      "~/Content/loginCss/style.scss"));

        }
    }
}
