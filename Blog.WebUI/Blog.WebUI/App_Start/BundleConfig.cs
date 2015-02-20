using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Blog.WebUI.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var scripts = new ScriptBundle("~/bundles/scripts");
            scripts.Include("~/Scripts/Lib/jquery-1.11.2.min.js");
            scripts.Include("~/Scripts/Layout/scriptL.js");

            bundles.Add(scripts);

            var addcoment = new ScriptBundle("~/bundles/addcoment");
            addcoment.Include("~/Scripts/Comments/AddComment.js");

            bundles.Add(addcoment);

            //var styles = new StyleBundle("~/css/styles");
            //styles.Include("~/Styles/StyleSheet1.css");
            //styles.Include("~/Styles/StyleSheetAddComment.css");
            //styles.Include("~/Styles/StyleSheetArticle.css");
            //styles.Include("~/Styles/StyleSheetArticleList.css");
            //styles.Include("~/Styles/StyleSheetNewArticle.css");

            //bundles.Add(styles);
        }
    }
}