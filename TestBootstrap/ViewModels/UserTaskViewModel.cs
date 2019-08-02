using System.ComponentModel.DataAnnotations;

namespace Microsoft.DiaryAppOlga.DiaryAppOlga.ViewModels
{
    public class UserTaskViewModel
    {
        public int UserTask_Id { get; set; }
        //???
        public int UserId { get; set; }
        public int Priority_Id { get; set; }

        [Required(ErrorMessage = "Set priority")]
        [Display(Name = "Priority")]
        public string PriorityName{ get; set; }
        
        public int Grade_Id { get; set; }
        public string GradeName { get; set; }

        [Required(ErrorMessage = "Set task")]
        [Display(Name = "Task")]
        [StringLength(50, MinimumLength = 3)]
        public string TaskName { get; set; }

        [StringLength(500, MinimumLength = 10 )]
        [Required]
        public string Description { get; set; }


        public bool Status { get; set; }


    }
}
