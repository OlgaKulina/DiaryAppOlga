
using System.Collections.Generic;


namespace DiaryAppOlga.Models.DbModels
{
    public class MonthlyPlan: BaseEntity
    {
               
        private static List<Month> CreateListWeeks()
        {
            return new List<Month>
            {
                { new Month(){MonthNumber=1}},
                { new Month(){MonthNumber=2}},
                { new Month(){MonthNumber=3}},
                { new Month(){MonthNumber=4}},
                { new Month(){MonthNumber=5}},
                { new Month(){MonthNumber=6}},
             };
        }

               
        public UserGoal UserGoal { get; set; }
        public WeeklyPlan WeeklyPlan { get; set; }


    }
}
