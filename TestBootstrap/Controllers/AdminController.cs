using Microsoft.AspNetCore.Mvc;
using DiaryAppOlga.Models;
using Microsoft.AspNetCore.Identity;


namespace DiaryAppOlga.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        public AdminController(UserManager<ApplicationUser> usrMgr)
        {
            userManager = usrMgr;
        }

        public ViewResult Users () => View(userManager.Users);
    }  
        
}
