using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestBootstrap.Models;

namespace TestBootstrap.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        DbSet<UserAim> UserAims { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
    }
}
