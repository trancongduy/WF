using System.Web;
using System.Web.Optimization;

namespace VMS.Portal
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/Themes/css").Include(
                      "~/Content/themes/css/theme.css",
                      "~/Content/themes/css/vendor.css",
                      "~/Content/themes/css/utility.css",
                       "~/Content/themes/vendor/bootstrap/css/bootstrap.min.css"
                      ));

            bundles.Add(new ScriptBundle("~/Content/Themes/js").Include(
                      "~/Content/themes/js/main.js",
                      "~/Content/themes/js/ajax.js",
                      "~/Content/themes/vendor/bootstrap/js/bootstrap.min.js",
                        "~/Content/themes/vendor/jquery/jquery-1.11.1.min.js",
                      "~/Content/themes/vendor/jquery/jquery_ui/jquery-ui.min.js"
                      ));
        }
    }
}
