using System.Collections.Generic;


namespace DiaryAppOlga.Models.DbModels
{
    public class Priorities: BaseEntity
    {
        //rewrite with flags
        public string PriorityName { get; set; }

        static IEnumerable<Priorities> GetPriorities()
        {
            return new List<Priorities>()
            {
             new Priorities() { PriorityName="High"},
             new Priorities() { PriorityName = "Medium"},
             new Priorities() { PriorityName = "Low"}
            };
        }
    }
}
