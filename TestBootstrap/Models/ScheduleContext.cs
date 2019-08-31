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
        

        //Database.EnsureCreated();
        }


    }

