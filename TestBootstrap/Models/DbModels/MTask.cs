using System.ComponentModel.DataAnnotations;


namespace DiaryAppOlga.Models.DbModels
{
    public class MTask : BaseEntity
    {


        [Required(ErrorMessage = "Set a task.")]
        [Display(Name = "Task")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Task length must be between 10 and 50 characters!")]
        public string TaskName { get; set; }

        [Required(ErrorMessage = "Add a description for the task. No more than 500 characters!")]
        [Display(Name = "Description")]
        [StringLength(500)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Set a priority for the task!")]
        [Display(Name = "Priority")]
        public Priorities Priorities { get; set; }


        public bool Status { get; private set; }

        public void Done()
        {
            this.Status = true;
        }

        public void NotDone()
        {
            this.Status = false;
        }

        public int GradeId { get; set; }
        public virtual Grade Grade { get; set; }
               
                
        public int UserGoalId { get; set; }
        public virtual UserGoal UserGoal { get; set; }

        public int MonthId { get; set; }
        public virtual Month Month { get; set; }


        

        
    }
}
