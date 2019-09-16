using DiaryAppOlga.Models.DbModels;
using System;
using System.ComponentModel.DataAnnotations;


namespace DiaryAppOlga.Models
{
    public class UserGoal: BaseEntity
    {       
        
        public virtual ApplicationUser ApplicationUser { get; set; }


        public int MonthlyPlanId { get; set; }
        public MonthlyPlan MonthlyPlan { get; set; }
               
                
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

        public void Done()
        {
            this.Status = true;
        }

        public void NotDone()
        {
            this.Status = false;
        }

        


    }
}
