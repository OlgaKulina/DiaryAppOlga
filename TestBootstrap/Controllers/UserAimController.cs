using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DiaryAppOlga.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DiaryAppOlga.Controllers
{
    public class UserAimController : Controller
    {
        private UserAimContext db;
        //private ApplicationUser user;

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
        
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAim(
        [Bind("Aim,Description,StartDate,EndDate")] UserAim _aim)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.UserAims.Add(_aim);
                    await db.SaveChangesAsync();
                    return RedirectToAction(nameof(Aim));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(_aim);
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

        //To do -->
        //public async Task<IActionResult> DetailsAim(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var _aim = await db.UserAims
        //         .Include(a => a.Aim)
        //             .ThenInclude(d => d.)
        //         .AsNoTracking()
        //         .FirstOrDefaultAsync(m => m.Id == id);

        //    if (_aim == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(_aim);
        //}


        

        public async Task<IActionResult> EditAim(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aim = await db.UserAims.FindAsync(id);
            if (aim == null)
            {
                return NotFound();
            }
            return View(aim);
        }

        [HttpPost, ActionName("EditAim")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAimPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var aimToUpdate = await db.UserAims.FirstOrDefaultAsync(a => a.Id == id);
            if (await TryUpdateModelAsync<UserAim>(
                aimToUpdate,
                "",
              a => a.UserId, a => a.Aim, a => a.Description, a => a.StartDate, a => a.EndDate))
            {
                try
                {
                    await db.SaveChangesAsync();
                    return RedirectToAction(nameof(Aim));
                }
                catch (DbUpdateException /* ex */)
                {
                    
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
            }
            return View(aimToUpdate);
        }


        
        public async Task<IActionResult> DeleteAim(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aim = await db.UserAims
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aim == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            return View(aim);
        }
        

        [HttpPost, ActionName("DeleteAim")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aim = await db.UserAims.FindAsync(id);
            if (aim == null)
            {
                return RedirectToAction(nameof(Aim));
            }

            try
            {
                db.UserAims.Remove(aim);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Aim));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(DeleteAim), new { Id = id, saveChangesError = true });
            }
        }

        private bool UserAimsExists(int id)
        {
            return db.UserAims.Any(e => e.Id == id);
        }
    }
}


    
