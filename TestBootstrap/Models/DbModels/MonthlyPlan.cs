
using System.Collections.Generic;


namespace DiaryAppOlga.Models.DbModels
{
    public class MonthlyPlan: BaseEntity
    {
        public int UserGoalId { get; set; }
        public virtual UserGoal UserGoal { get; set; }

        public int WeeklyPlanId { get; set; }
        public virtual WeeklyPlan WeeklyPlan { get; set; }
               
        private static List<Month> CreateListMonths()
        {
            List<Month> tmp = new List<Month>(6);
            for (int i = 0; i <= 6; i++)
            {
                tmp.Add(new Month() { MonthNumber = i });

            }

            return tmp;                                    
        }

        
    }
}
