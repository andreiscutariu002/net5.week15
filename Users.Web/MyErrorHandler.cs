namespace Users.Web
{
    using System.Web.Mvc;

    // use handler for errors
    public class MyErrorHandler : FilterAttribute, IExceptionFilter
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
