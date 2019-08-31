

namespace DiaryAppOlga.Models
{
    public class DailyTask
    {
        
        public int DailyTasks_Id { get; set; }
        


        public int UserTask_Id { get; set; }
        public UserTask UserTask { get; set; }
    }
}
