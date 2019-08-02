using System;
using System.ComponentModel.DataAnnotations;


namespace DiaryAppOlga.ViewModels
{
    public class DailyTasksViewModel
    {
       
        public int DailyTasks_Id { get; set; }
        public int NumberTask { get; set; }
        
        [Required(ErrorMessage = "Set date")]
        [Display(Name = "Date")]
        public DateTime SetDate { get; set; }


        //???
        public int Grade_Id { get; set; }

        //???
        [Required(ErrorMessage = "Set Grade")]
        [Display(Name = "Grade")]
        public string GradeName { get; set; }


    }
}
