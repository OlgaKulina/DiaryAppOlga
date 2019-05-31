using System;
using System.ComponentModel.DataAnnotations;

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
