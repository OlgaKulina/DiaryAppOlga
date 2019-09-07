using System;
using System.ComponentModel.DataAnnotations;

namespace DiaryAppOlga.Models
{
    public enum Priorities
    {
        High, Medium, Low
    }

    public class MonthlyTask
    {

        public int MonthlyTaskId { get; set; }

        [Required(ErrorMessage = "Set a task.")]
        [Display(Name = "Task")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Task length must be between 10 and 50 characters!")]
        public string TaskName { get; set; }

        [Required(ErrorMessage = "Add a description for the task. No more than 500 characters!")]
        [Display(Name = "Description")]
        [StringLength(500)]
        public string Description { get; set; }


        public bool Status { get; private set; }

        [Required(ErrorMessage = "Set a priority for the task!")]
        [Display(Name = "Priority")]
        public Priorities? Priorities { get; set; }


        public Grade Grade { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }




        public void Done()
        {
            Status = true;
        }

        public void NotDone()
        {
            Status = false;
        }

        // Realization of the connection between Goal and Monthly Tasks

        public int GoalId {get;set;}
        public Goal Goal { get; set; }


        //Create a method that validates date input



    }
}
