using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DiaryAppOlga.Models;

namespace DiaryAppOlga.Controllers
{
    public class UserAimController : Controller
    {
        private UserAimContext db;

        public UserAimController(UserAimContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Aim()
        {
            return View(await db.UserAims.ToListAsync());
        }

        public IActionResult CreateAim()
        {
            return View();
        }

        //public IActionResult DetailsAim()
        //{
        //    return View();
        //}

        [HttpPost]
        public async Task<IActionResult> CreateAim(UserAim aim_)
        {
            db.UserAims.Add(aim_);
            await db.SaveChangesAsync();
            return RedirectToAction("Aim");
        }

        public async Task<IActionResult> DetailsAim(int? id)
        {
            if (id != null)
            {
                UserAim userAim = await db.UserAims.FirstOrDefaultAsync(a => a.Id == id);
                if (userAim != null)
                    return View(userAim);
            }
            return NotFound();
        }


        


    }
}