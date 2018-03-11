using System.Web.Optimization;

namespace FCMontgomery.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/font.awesome.min.css",
                      "~/Content/font.mont.serrat.css",
                      "~/Content/font.kaushan.script.css",
                      "~/Content/font.droid-serif.css",
                      "~/Content/font.roboto.slab.css",
                      "~/Content/modern-business.css",
                      "~/Content/agency.css"));

            bundles.Add(new ScriptBundle("~/bundles/scripts")
                .Include("~/Scripts/jquery.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/jquery.easing.min.js",
                //"~/Scripts/jquery.bootstrap.validation.js",
                // "~/Scripts/contactme.js",
                "~/Scripts/agency.min.js"
            ));
        }
    }
}
