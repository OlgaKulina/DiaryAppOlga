using System;
using System.ComponentModel.DataAnnotations;

namespace DiaryAppOlga.ViewModels
{
    public class WeeklyTasksViewModel
    {
        public int WeeklyTasks_Id { get; set; }

        //???
        public int DailyTasks_Id { get; set; }
        public int NumberTask { get; set; }

        public int Grade_Id { get; set; }

        [Required(ErrorMessage = "Set Grade")]
        [Display(Name = "Grade")]
        public string GradeName { get; set; }

        [Required(ErrorMessage = "Set start date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Start_date { get; set; }

        [Required(ErrorMessage = "Set end date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime End_date { get; set; }

    }
}
