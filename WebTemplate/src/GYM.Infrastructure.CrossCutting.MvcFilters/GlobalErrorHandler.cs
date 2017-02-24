using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace GYM.Infrastructure.CrossCutting.MvcFilters
{
  public class GlobalErrorHandler : ActionFilterAttribute
  {
    public override void OnActionExecuted(ActionExecutedContext filterContext)
    {
      if (filterContext.Exception != null) {
        //deal with logging the error
      }
      base.OnActionExecuted(filterContext);
    }
  }
}
