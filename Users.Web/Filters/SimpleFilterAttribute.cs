﻿namespace Users.Web.Filters
{
    using System.Web.Mvc;

    public class SimpleFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }
    }
}
