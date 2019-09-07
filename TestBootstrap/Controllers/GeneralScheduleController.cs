using DiaryAppOlga.Models;
using DiaryAppOlga.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DiaryAppOlga.Controllers
{
    public class GeneralScheduleController : Controller
    {
        private IDataRepository<Goal> goalRepository;
        private IDataRepository<MonthlyTask> mtaskRepository;
        private IDataRepository<WeeklyTask> wtaskRepository;

        private GeneralScheduleController(IDataRepository<Goal> repo) => goalRepository = repo;
        public GeneralScheduleController(IDataRepository<MonthlyTask> repoMT) => mtaskRepository = repoMT;
        private GeneralScheduleController(IDataRepository<WeeklyTask> repoWT) => wtaskRepository = repoWT;



        //Goals
        public IActionResult Goals()
        {
            //Console.Clear();
            return View(goalRepository.ListAll);
        }
               
        
        [HttpPost]
        public IActionResult AddGoal(Goal goal)
        {
            goalRepository.Add(goal);
            return RedirectToAction(nameof(Goals));
        }

        //Edit Goal
        public IActionResult UpdateGoal(int key)
        {

            return View(goalRepository.GetById(key));
        }

        [HttpPost]
        public IActionResult UpdateGoal(Goal goal)
        {

            goalRepository.Update(goal);
            return RedirectToAction(nameof(Goals));
        }


        [HttpPost]
        public IActionResult DeleteGoal(Goal goal)
        {

            goalRepository.Delete(goal);
            return RedirectToAction(nameof(Goals));
        }


        //Monthly Tasks
        public IActionResult MonthlyTasks1()
        {
            //Console.Clear();
            return View(mtaskRepository.ListAll);
        }

        [HttpPost]
        public IActionResult AddMonthlyTask(MonthlyTask monthlyTask)
        {
            mtaskRepository.Add(monthlyTask);
            return RedirectToAction(nameof(MonthlyTasks1));
        }

        //Edit monthly task
        public IActionResult UpdateMonthlyTask(int key1)
        {

            return View(mtaskRepository.GetById(key1));
        }

        [HttpPost]
        public IActionResult UpdateMonthlyTask(MonthlyTask monthlyTask)
        {

            mtaskRepository.Update(monthlyTask);
            return RedirectToAction(nameof(MonthlyTasks1));
        }


        [HttpPost]
        public IActionResult DeleteMonthlyTask(MonthlyTask monthlyTask)
        {

            mtaskRepository.Delete(monthlyTask);
            return RedirectToAction(nameof(MonthlyTasks1));
        }



        //Weekly Tasks
        public IActionResult WeeklyTasks1()
        {
            //Console.Clear();
            return View(wtaskRepository.ListAll);
        }

        [HttpPost]
        public IActionResult AddWeeklyTask(WeeklyTask weeklyTask)
        {
            wtaskRepository.Add(weeklyTask);
            return RedirectToAction(nameof(WeeklyTasks1));
        }

        
        public IActionResult UpdateWeeklyTask(int key1)
        {

            return View(wtaskRepository.GetById(key1));

        }

        [HttpPost]
        public IActionResult UpdateWeeklyTask(WeeklyTask weeklyTask)
        {

            wtaskRepository.Update(weeklyTask);
            return RedirectToAction(nameof(WeeklyTasks1));
        }


        [HttpPost]
        public IActionResult DeleteWeeklyTask(WeeklyTask weeklyTask)
        {

            wtaskRepository.Delete(weeklyTask);
            return RedirectToAction(nameof(WeeklyTasks1));
        }









        public IActionResult AllSchedules1()
        {
            return View();
        }

        public IActionResult Schedule1()
        {
            return View();
        }



        //public IActionResult WeeklyTasks1()
        //{
        //    return View();
        //}

        public IActionResult DailyTasks1()
        {
            return View();
        }
    }
}