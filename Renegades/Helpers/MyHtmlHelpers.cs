using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Renegades.Helpers
{
    public static class MyHtmlHelpers
    {

        public static MvcHtmlString MyMainMenu(this HtmlHelper helper, string linkText,
            string actionName, string controllerName)
        {
            string currentAction = helper.ViewContext.RouteData.GetRequiredString("action");
            string currentController = helper.ViewContext.RouteData.GetRequiredString("controller");
          
            if (controllerName == currentController && currentAction==actionName)
            {
                return helper.ActionLink(
                    linkText,
                    actionName,
                    controllerName,
                    null,
                    new
                    {
                        @class = "active_tm"
                    });
            }
            return helper.ActionLink(linkText, actionName, controllerName);
        }

        public static MvcHtmlString Truncate(this HtmlHelper helper, string input, int length)
        {
            if (input.Length <= length)
            {
                return new MvcHtmlString(input);
            }
            input = input.Substring(0, length)+".....";
            return new MvcHtmlString(input);
        }


    }
}