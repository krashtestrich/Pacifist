using System.Web.Optimization;

namespace PacifistWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/angular").Include(
                "~/Scripts/angular.min.js", 
                "~/Scripts/angular-route.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/pacifistapp")
                .IncludeDirectory("~/Scripts/app", "*.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
