using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using DiaryAppOlga.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DiaryAppOlga.Controllers
{
    public class RoleAdminController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        private UserManager<ApplicationUser> userManager;
        public RoleAdminController(RoleManager<IdentityRole> roleMgr, UserManager<ApplicationUser> userMrg) {
            roleManager = roleMgr;
            userManager = userMrg;
        }

        public ViewResult _Index() => View(roleManager.Roles);

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create([Required] string name)
        {
            if (ModelState.IsValid){
                IdentityResult result = await roleManager.CreateAsync(new IdentityRole(name));
                if (result.Succeeded){
                    return RedirectToAction("_Index");
                } else{
                    AddErrorsFromResult(result);
                                       
                }               
                            }
            return View(name);
        }


        [HttpPost]
        public async Task<IActionResult> Delete(string id){
            IdentityRole role = await roleManager.FindByIdAsync(id);
            if (role != null){
                IdentityResult result = await roleManager.DeleteAsync(role);
                if (result.Succeeded){
                    return RedirectToAction("_Index");
                }
                else {
                    ModelState.AddModelError("", "No role found");
                     }                
            }
            return View("_Index", roleManager.Roles);
        }

        public async Task<IActionResult> Edit (string id) {
            IdentityRole role = await roleManager.FindByIdAsync(id);
            List<ApplicationUser> members = new List<ApplicationUser>();
            List<ApplicationUser> nonMembers = new List<ApplicationUser>();
            foreach (ApplicationUser user in userManager.Users){
                var list = await userManager.IsInRoleAsync(user, role.Name)
                    ? members : nonMembers;
                list.Add(user);
            }
            return View(new RoleEditModel
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers

            });
        }

        [HttpPost]
        public async Task<IActionResult> Edit (RoleModificationModel model) {
            IdentityResult result;
            if (ModelState.IsValid) {
                foreach (string userId in model.IdsToAdd??new string[] { }) {
                    ApplicationUser user = await userManager.FindByEmailAsync(userId);
                    if (user != null) {
                        result = await userManager.AddToRoleAsync(user, model.RoleName);
                        if (!result.Succeeded){
                            AddErrorsFromResult(result);
                        }
                    }
                }
                foreach (string userId in model.IdsToDelete??new string[] { }) {
                    ApplicationUser user = await userManager.FindByEmailAsync(userId);
                    if (user != null) {
                        result = await userManager.RemoveFromRoleAsync(user,
                            model.RoleName);
                        if (!result.Succeeded) {
                            AddErrorsFromResult(result);
                        }
                    }
                }
           }
            if (ModelState.IsValid) {
                return RedirectToAction(nameof(_Index));
            } else  {
                return await Edit(model.RoleId);

            }
        }

        private void AddErrorsFromResult(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }           
           
        }
              
    }
}