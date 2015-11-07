using System.Web;
using System.Web.Optimization;

namespace eskisehirNET.Admin
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                      "~/Content/vendor/modernizr/modernizr.min.js",
                      "~/Content/vendor/breakpoints/breakpoints.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/bootstrap-extend.min.css",
                      "~/Content/css/site.min.css",
                      "~/Content/vendor/animsition/animsition.min.css",
                      "~/Content/vendor/asscrollable/asScrollable.min.css",
                      "~/Content/vendor/switchery/switchery.min.css",
                      "~/Content/vendor/intro-js/introjs.min.css",
                      "~/Content/vendor/slidepanel/slidePanel.min.css",
                      "~/Content/vendor/flag-icon-css/flag-icon.min.css",
                       "~/Content/fonts/web-icons/web-icons.min.css",
                        "~/Content/fonts/brand-icons/brand-icons.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryCore").Include(
            "~/Content/vendor/jquery/jquery.min.js",
            "~/Content/vendor/bootstrap/bootstrap.min.js",
            "~/Content/vendor/animsition/jquery.animsition.min.js",
            "~/Content/vendor/asscroll/jquery-asScroll.min.js",
            "~/Content/vendor/mousewheel/jquery.mousewheel.min.js",
            "~/Content/vendor/asscrollable/jquery.asScrollable.all.min.js",
            "~/Content/vendor/ashoverscroll/jquery-asHoverScroll.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryCPlugin").Include(
            "~/Content/vendor/switchery/switchery.min.js",
            "~/Content/vendor/intro-js/intro.min.js",
            "~/Content/vendor/screenfull/screenfull.js",
            "~/Content/vendor/slidepanel/jquery-slidePanel.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryScripts").Include(
            "~/Content/js/core.min.js",
            "~/Content/js/site.min.js",
            "~/Content/js/sections/menu.min.js",
            "~/Content/js/sections/menubar.min.js",
            "~/Content/js/sections/gridmenu.min.js",
            "~/Content/js/sections/sidebar.min.js",
            "~/Content/js/configs/config-colors.min.js",
            "~/Content/js/configs/config-tour.min.js",
            "~/Content/js/components/asscrollable.min.js",
            "~/Content/js/components/animsition.min.js",
            "~/Content/js/components/slidepanel.min.js",
            "~/Content/js/components/switchery.min.js"));

            bundles.Add(new StyleBundle("~/Content/Index").Include(
                     "~/Content/examples/css/widgets/statistics.css"));
        }
    }
}
