using System;
using System.ComponentModel.DataAnnotations;

namespace TestBootstrap.Models
{
    public class UserAim
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        //[Required(ErrorMessage = "Set aim")]
        //[Display(Name = "Aim")]
        public string Aim { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set;}


    }
}
