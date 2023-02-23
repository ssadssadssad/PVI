using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace laba5.Controllers
{
    public class AResearchController : Controller
    {
        // GET: AResearch
        [F1]
        public void AA()
        {
            Response.Write("AA");
        }

        [F2]
        public void AR()
        {
            Response.Write("AR");
        }

        [F3]
        public void AE()
        {
            throw new Exception("ERROR");
            Response.Write("AE");
        }

        public class F1Attribute : FilterAttribute, IActionFilter
        {
            public void OnActionExecuting(ActionExecutingContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<li>F1:До выполнения метода AA</li>");
            }
            public void OnActionExecuted(ActionExecutedContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<li>F1:После выполнения метода AA</li>");
            }
        }

        public class F2Attribute : FilterAttribute, IResultFilter
        {
            public void OnResultExecuting(ResultExecutingContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<li>F2:До возвращения результата AR</li>");
            }

            public void OnResultExecuted(ResultExecutedContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<li>F2:После возвращения результата AR</li>");
            }
        }

        public class F3Attribute : FilterAttribute, IExceptionFilter
        {
            public void OnException(ExceptionContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<li>F3:Исключение в AE</li>");
                ViewResult vr = new ViewResult();
                vr.ViewName = "ERROR";
                filterContext.Result = vr;
                filterContext.ExceptionHandled = true;
            }
        }
    }
}