using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DiaryAppOlga.Models
{
    public class ScheduleContext : DbContext
    {

        public ScheduleContext(DbContextOptions<ScheduleContext> options)
            : base(options)
        { }
        
        public DbSet<UserTask> UserTasks { get; set; }
        //public DbSet<MonthlyTask> MonthlyTasks { get; set; }
        //public DbSet<WeeklyTask> WeeklyTasks { get; set; }
        //public DbSet<DailyTask> DailyTasks { get; set; }


        //Database.EnsureCreated();
        }


    }

