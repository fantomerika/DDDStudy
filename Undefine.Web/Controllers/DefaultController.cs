using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Undefine.App;
using Undefine.Repository;
using Undefine.Repository.Repositories;

namespace Undefine.Web.Controllers
{
    public class DefaultController : Controller
    {
        public UserManagerApp MyProperty { get; set; }

        public DefaultController(UserManagerApp app)
        {
            MyProperty = app;
        }

        public IActionResult Index()
        {
            MyProperty.GetUsers(null);
            //var a = new UserManagerApp(new Sys_UserRepository(new EFUnitOfWork())).GetUsers(null);
            return View();
        }
    }
}