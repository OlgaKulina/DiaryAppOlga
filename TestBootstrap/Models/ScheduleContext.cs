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
        //public DbSet<ScheduleItem> ScheduleItems { get; set; }
        //public DbSet<MonthlyTask> MonthlyTasks { get; set; }
        public DbSet<UserTask> UserTasks { get; set; }
        //public DbSet<Priority> Priorities { get; set; }
        //public DbSet<Grade> Grades { get; set; }

        //Database.EnsureCreated();
        }


    }

