using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DiaryAppOlga.Controllers
{
    public class ScheduleController : Controller
    {
        public IActionResult AllSchedules()
        {
            return View();
        }

        public IActionResult Schedule()
        {
            return View();
        }


        public IActionResult MonthlyTasks()
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