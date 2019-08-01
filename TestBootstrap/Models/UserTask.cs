using System.ComponentModel.DataAnnotations;

namespace DiaryAppOlga.Models
{
    public class UserTask
    {
        public int UserId { get; set; }
        public int UserTask_Id { get; set; }
        public int Priority_Id { get; set; }
        //public int Period_Id { get; set; }
        public int Grade_Id { get; set; }

        [Required(ErrorMessage = "Set task")]
        [Display(Name = "Task")]
        public string TaskName { get; set; }

        public string Description { get; set; }
        public bool Status { get; set; }

        

    }
}
