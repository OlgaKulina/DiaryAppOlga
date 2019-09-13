using System.Collections.Generic;


namespace DiaryAppOlga.Models.DbModels
{
    public class WeeklyPlan: BaseEntity
    {
        List<Week> weeks = new List<Week>(4);
    }
}
