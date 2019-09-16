using System.Collections.Generic;


namespace DiaryAppOlga.Models.DbModels
{
    public class DailyPlan : BaseEntity
    {
        public int WeeklyPlanId { get; set; }
        public virtual WeeklyPlan WeeklyPlan { get; set; }

        private static List<Day> CreateListDays()
        {
            List<Day> tmp = new List<Day>(30);
            for(int i=0;i<=30;i++)
            {
                tmp.Add(new Day() { DayNumber = i });

            }
            return tmp;       

        }                                


    }
}

