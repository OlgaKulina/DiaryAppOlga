using System.Collections.Generic;


namespace DiaryAppOlga.Models.DbModels
{
    public class WeeklyPlan : BaseEntity
    {
        //List<Week> weeks = new List<Week>(4);

        private static List<Week> CreateListWeeks()
        {
            return new List<Week>
            {
                { new Week(){WeekNumber=1}},
                { new Week(){WeekNumber=2}},
                { new Week(){WeekNumber=3}},
                { new Week(){WeekNumber=4}}
             };
         }

        public MonthlyPlan MonthlyPlan { get; set; }
        public DailyPlan DailyPlan { get; set; }

    }

   


}
    