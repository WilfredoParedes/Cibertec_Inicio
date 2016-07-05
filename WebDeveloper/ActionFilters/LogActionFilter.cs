using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebDeveloper.ActionFilters
{
   public class LogActionFilter : ActionFilterAttribute
    {
        

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("OnActionExecuting",filterContext.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Log("OnResultExecuting", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log("OnResultExecuted", filterContext.RouteData);
        }      

       
        public void Log(string actionMethod, RouteData routeData)
        {
            var controlName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var message = $"OnResultExecuted controller: {controlName} action: {actionName}";
            Debug.WriteLine(message, "Action Filter Log");
        }
    }
}
