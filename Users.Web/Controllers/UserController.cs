namespace Users.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using BusinessLogic;
    using Data;
    using Models;

    [SimpleFilter]
    [MyErrorHandler] 
    public class UserController : Controller
    {
        private readonly IUserRepository repo;

        public UserController()
        {
            this.repo = new UserRepository(ConnectionManager.GetConnection());
        }

        [HttpGet]
        public ActionResult Index()
        {
            // entity from database
            List<User> allUsers = this.repo.GetAll();

            // model for view
            List<UserListViewModel> list = new List<UserListViewModel>();

            foreach (var user in allUsers)
            {
                list.Add(new UserListViewModel
                {
                    Id = user.Id,
                    Email = user.Email,
                    UserName = user.Username
                });
            }

            return this.View(list);
        }

        [HttpGet]
        public ActionResult CreateUser()
        {
            //try
            //{
            //    throw new NotImplementedException();
            //}
            //catch (Exception e)
            //{
            //    // log error

            //    return this.RedirectToAction("Error", "Home");
            //}

            // ex
            throw new NotImplementedException();
        }


        // https://stackify.com/aspnet-mvc-error-handling/
        // move this in base controller
        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;

            // todo - log error

            filterContext.Result = this.RedirectToAction("Error", "Home");

            // or

            //filterContext.Result = new ViewResult
            //{
            //    ViewName = "~/Views/Home/Error.cshtml"
            //};
        }
    }
}
