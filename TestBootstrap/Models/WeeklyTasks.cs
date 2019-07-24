using System;


namespace DiaryAppOlga.Models
{
    public class WeeklyTasks
    {
        public int UserTask_Id { get; set; }
        public int WeeklyTasks_Id { get; set; }
        public int DailyTasks_Id { get; set; }
        public int NumberTask { get; set; }
        public int Grade_Id { get; set; }

        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }


    }
}
