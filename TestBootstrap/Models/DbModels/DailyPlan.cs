using System.Collections.Generic;
using System.Linq;

namespace DiaryAppOlga.Models.DbModels
{
    public class DailyPlan : BaseEntity
    {
        public int WeeklyPlanId { get; set; }
        public virtual WeeklyPlan WeeklyPlan { get; set; }

        //public static void CreateListDays(DatabaseContext context)
        //{

        //    var tmp = new List<Day>(30);
            
        //        for (int i = 0; i <= 30; i++)
        //        {
        //            tmp.Add(new Day() { DayNumber = i });
        //            //tmp.ForEach(Day => context.Days.Add(new Day() { DayNumber = i }));
        //            context.SaveChanges();
        //        }
        //        //return tmp;            
        //}




        //private static List<Day> CreateListDays()
        //{
        //    List<Day> tmp = new List<Day>(30);
        //    for (int i=0; i<=30; i++)
        //    {
        //        tmp.Add(new Day() { DayNumber = i });

        //    }
        //    return tmp;       

        //}                                


    }
}

