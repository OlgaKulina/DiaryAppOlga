using System;
using System.ComponentModel.DataAnnotations;


namespace DiaryAppOlga.ViewModels
{
    public class MonthlyTasksViewModel
    {
        public int MonthlylyTasks_Id { get; set; }
        public int WeeklyTasks_Id { get; set; }
        
        public int NumberTask { get; set; }

        public int Grade_Id { get; set; }

        [Required(ErrorMessage = "Set Grade")]
        [Display(Name = "Grade")]
        public string GradeName { get; set; }

        [Required(ErrorMessage = "Set start date")]
        public DateTime Start_date { get; set; }

        [Required(ErrorMessage = "Set end date")]
        public DateTime End_date { get; set; }

    }
}
