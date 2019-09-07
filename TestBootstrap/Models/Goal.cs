using System;
using System.ComponentModel.DataAnnotations;


namespace DiaryAppOlga.Models
{
    public class Goal
    {

        public int GoalId { get; set; }

        //public ApplicationUser UserName { get; set; }

        //public ApplicationUser ApplicationUser { get; set; }
        
        [Required(ErrorMessage = "Set your goal!")]
        [Display(Name = "Goal")]
        public string GoalName { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        public bool Status { get; set; }



    }
}
