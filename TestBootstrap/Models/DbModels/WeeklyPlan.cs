using System.Collections.Generic;


namespace DiaryAppOlga.Models.DbModels
{
    public class WeeklyPlan : BaseEntity
    {
        public int MonthlyPlanId { get; set; }
        public virtual MonthlyPlan MonthlyPlan { get; set; }


        public int DailyPlanId { get; set; }
        public virtual DailyPlan DailyPlan { get; set; }


        private static List<Week> CreateListWeeks()
        {
            List<Week> tmp = new List<Week>(4);
            for (int i = 0; i <= 4; i++)
            {
                tmp.Add(new Week() { WeekNumber = i });

            }

            return tmp;
                        
        }

        
    }

   


}
    