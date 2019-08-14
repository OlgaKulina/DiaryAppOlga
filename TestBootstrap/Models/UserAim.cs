using System;
using System.ComponentModel.DataAnnotations;

namespace DiaryAppOlga.Models
{
    public class UserAim
    {
        public int Id { get; set; }

        public int UserId { get; set; }


        //public string UserId { get; set; }

        //[Required(ErrorMessage = "Set your goal!")]
        //[Display(Name = "Goal")]
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
