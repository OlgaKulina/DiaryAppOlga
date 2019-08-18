using Microsoft.AspNetCore.Mvc;
using DiaryAppOlga.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace DiaryAppOlga.Controllers
{
    //[Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        public AdminController(UserManager<ApplicationUser> usrMgr)
        {
            userManager = usrMgr;
        }

        public ViewResult Users() => View(userManager.Users);
    }

}
