using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        //"~/Scripts/modernizr-*"
                        "~/Theme/js/vendor/modernizr-2.8.3.min.js"


                        ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/Theme").Include(
                   "~/Theme/css/accordions.css",
                   "~/Theme/css/alerts.css",
                   "~/Theme/css/animate.css",
                   "~/Theme/css/bootstrap.min.css",
                   "~/Theme/css/buttons.css",
                   "~/Theme/css/font-awesome.min.css",
                   "~/Theme/css/main.css",
                   "~/Theme/css/meanmenu.min.css",
                   "~/Theme/css/modals.css",
                   "~/Theme/css/normalize.css",
                   "~/Theme/css/owl.carousel.css",
                   "~/Theme/css/owl.transitions.css",
                   "~/Theme/css/responsive.css",
                   "~/Theme/css/tabs.css",
                   "~/Theme/css/owl.theme.css",
                   "~/Theme/css/form/all-type-forms.css",
                   "~/Theme/css/form/themesaller-forms.css",
                   "~/Theme/css/tree-viewer/tree-viewer.css",
                   "~/Theme/css/select2/select2.min.css",
                   "~/Theme/css/notifications/Lobibox.min.css",
                   "~/Theme/css/notifications/notifications.css",
                   "~/Theme/css/css/c3.css",
                   "~/Theme/css/morrisjs/morris.css",
                   "~/Theme/css/notifications/Lobibox.min.css",
                   "~/Theme/css/notifications/notifications.css",
                   "~/Theme/css/scrollbar/jquery.mCustomScrollbar.min.css",
                   "~/Theme/css/preloader/preloader-style.css",
                   "~/Theme/css/tree-viewer/tree-viewer.css",
                   "~/Theme/css/form/all-type-forms.css",
                   "~/Theme/css/form/themesaller-forms.css",
                   "~/Theme/css/editor/bootstrap-editable.css",
                   "~/Theme/css/editor/datetimepicker.css",
                   "~/Theme/css/editor/select2.css",
                   "~/Theme/css/editor/x-editor-style.css",
                   "~/Theme/css/metisMenu/metisMenu-vertical.css",
                   "~/Theme/css/metisMenu/metisMenu.min.css",
                   "~/Theme/css/datapicker/colorpicker.css",
                   "~/Theme/css/datapicker/datepicker3.css",
                   "~/Theme/css/dropzone/dropzone.css",
                   "~/Theme/css/calendar/fullcalendar.min.css",
                   "~/Theme/css/calendar/fullcalendar.print.min.css",


                  "~/Theme/css/style.css"
                   ));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                   "~/Theme/c3-charts/c3-active.js",
                   "~/Theme/c3-charts/c3.min.js",
                   "~/Theme/c3-charts/d3.min.js",
                   "~/Theme/calendar/fullcalendar-active.js",
                   "~/Theme/calendar/fullcalendar.min.js",
                   "~/Theme/calendar/moment.min.js",
                   "~/Theme/code-editor/code-editor-active.js",
                   "~/Theme/code-editor/code-editor.js",
                   "~/Theme/code-editor/codemirror.js",
                   "~/Theme/colorpicker/color-picker-active.js",
                   "~/Theme/colorpicker/jquery.spectrum.min.js",
                   "~/Theme/js/vendor/jquery-1.11.3.min.js",
                   "~/Theme/js/bootstrap.min.js",
                   "~/Theme/js/wow.min.js",
                   "~/Theme/js/jquery-price-slider.js",
                   "~/Theme/js/jquery.meanmenu.js",
                   "~/Theme/js/owl.carousel.min.js",
                   "~/Theme/js/jquery.sticky.js",
                   "~/Theme/js/jquery.scrollUp.min.js",
                   "~/Theme/js/scrollbar/jquery.mCustomScrollbar.concat.min.js",
                   "~/Theme/js/scrollbar/mCustomScrollbar-active.js",
                   "~/Theme/js/metisMenu/metisMenu.min.js",
                   "~/Theme/js/metisMenu/metisMenu-active.js",
                   //"~/Theme/js/morrisjs/raphael-min.js",
                   //"~/Theme/js/morrisjs/morris.js",
                   //"~/Theme/js/morrisjs/morris-active.js",
                   //"~/Theme/js/morrisjs/morris-active-pro.js",
                   //"~/Theme/js/sparkline/jquery.sparkline.min.js",
                   //"~/Theme/js/sparkline/jquery.charts-sparkline.js",
                   "~/Theme/js/calendar/moment.min.js",
                   //"~/Theme/js/calendar/fullcalendar.min.js",
                   //"~/Theme/js/calendar/fullcalendar-active.js",
                   "~/Theme/js/plugins.js",
                   "~/Theme/js/vendor/modernizr-2.8.3.min.js",
                   "~/Theme/js/main.js"
                   ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

          
        }
    }
}
