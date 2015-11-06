﻿using System.Web;
using System.Web.Optimization;

namespace RSPNMISv2
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            bundles.Add(new ScriptBundle("~/bundles/dataTable").Include(
                     "~/Scripts/DataTables/jquery.dataTables.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/theme").Include(
                   "~/Scripts/js/jquery.min.js",
                   "~/Scripts/js/bootstrap.min.js",
                   "~/Scripts/js/nicescroll/jquery.nicescroll.min.js",
                   "~/Scripts/js/icheck/icheck.min.js",
                   "~/Scripts/js/moment.min.js",
                   "~/Scripts/js/multiselect.min.js",
                   "~/Scripts/js/custom.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/dataTable").Include(
                    "~/Content/css/datatables/tools/css/dataTables.tableTools.css"));
            bundles.Add(new StyleBundle("~/Content/theme").Include(
                  "~/Content/css/bootstrap.min.css",
                   "~/fonts/css/font-awesome.min.css",
                  "~/Content/css/animate.min.css",
                  "~/Content/css/custom.css",
                  "~/Content/css/normalize.css",
                  "~/Content/style.css",
                  "~/Content/css/icheck/flat/green.css"));
        }

    }
}
