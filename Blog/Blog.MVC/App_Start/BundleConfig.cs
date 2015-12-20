using System.Web;
using System.Web.Optimization;

namespace Blog.MVC
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {


//            <script src='@Url.Content("~/Scripts/jquery-2.1.4.min.js")' type="text/javascript"></script>
//<script src='@Url.Content("~/Scripts/jquery-ui.min.js")' type="text/javascript"></script>


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-2.1.4.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            "~/Scripts/bootstrap*",
            "~/Scripts/npm.js"
            ));

            //bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                
                "~/Content/bootstrap*",
                "~/Content/font-awesome.min.css",
                "~/Content/site.css"
                ));

            //            <link href='@Url.Content("~/Content/jq/jquery-ui.min.css")' rel="stylesheet" type="text/css" />
            //<link href='@Url.Content("~/Content/jq/jquery-ui.structure.min.css")' rel="stylesheet" type="text/css" />
            //<link href='@Url.Content("~/Content/jq/jquery-ui.theme.min.css")' rel="stylesheet" type="text/css" />

            bundles.Add(new StyleBundle("~/Content/jq").Include(
                        "~/Content/jq/jquery-ui*",
                        "~/Content/jq/jquery-ui.min.css",
                        "~/Content/jq/jquery-ui.structure.min.css",
                        "~/Content/jq/jquery-ui.theme.min.css"));
        }
    }
}