using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBootstrap.Models
{
    public class UserAim
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Aim { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set;}


    }
}
