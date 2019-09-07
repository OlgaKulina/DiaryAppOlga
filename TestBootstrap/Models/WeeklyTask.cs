using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiaryAppOlga.Models
{
    public enum PrioritiesW
    {
        High, Medium, Low
    }


    public abstract class WeeklyTask
    {
        
        public int Id { get; set; }

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
        public PrioritiesW? PrioritiesW { get; set; }


        public Grade Grade { get; set; }    
                     
    }



    
    public class FirstWeek : WeeklyTask { /*public string NumberWeek= { }*/ }

    
    public class SecondWeek : WeeklyTask { }

   
    public class ThirdWeek : WeeklyTask { }

    
    public class FourthWeek : WeeklyTask { }



}
