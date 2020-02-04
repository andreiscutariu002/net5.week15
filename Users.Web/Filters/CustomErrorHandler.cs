namespace Users.Web.Filters
{
    using System.Web.Mvc;

    // use handler for errors
    public class CustomErrorHandler : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;

            filterContext.Result = new ViewResult
            {
                ViewName = "~/Views/Home/Error.cshtml"
            };
        }
    }
}
