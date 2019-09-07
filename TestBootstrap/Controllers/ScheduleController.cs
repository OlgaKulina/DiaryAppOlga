using DiaryAppOlga.Models;
using DiaryAppOlga.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DiaryAppOlga.Controllers
{
    public class ScheduleController : Controller
    {
        private IRepository repository;

        public ScheduleController(IRepository repo) => repository = repo;

        public IActionResult MonthlyTasks()
        {
            //Console.Clear();
            return View(repository.UserTasks);
        }

        [HttpPost]
        public IActionResult AddUserTask(UserTask userTask)
        {
            repository.AddUserTask(userTask);
            return RedirectToAction(nameof(MonthlyTasks));
        }

        //Edit task
        public IActionResult UpdateUserTask(int key){

            return View(repository.GetUserTask(key));
        }

        [HttpPost]
        public IActionResult UpdateUserTask(UserTask userTask) {

            repository.UpdateUserTask(userTask);
            return RedirectToAction(nameof(MonthlyTasks));
        }

        
        [HttpPost]
        public IActionResult DeleteUserTask(UserTask userTask) {

            repository.DeleteUserTask(userTask);
            return RedirectToAction(nameof(MonthlyTasks));
        }



        public IActionResult AllSchedules()
        {
            return View();
        }

        public IActionResult Schedule()
        {
            return View();
        }


        
        public IActionResult WeeklyTasks()
        {
            return View();
        }

        public IActionResult DailyTasks()
        {
            return View();
        }

        
    }

         
}
