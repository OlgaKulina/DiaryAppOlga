

using System.Collections.Generic;

namespace DiaryAppOlga.Models
{
    public class Priority
    {
        public int Priority_Id { get; set; }
        public string PriorityName { get; set; }

        static IEnumerable<Priority> GetPriorities()
        {
            return new List<Priority>()
            {
             new Priority() { PriorityName="High"},
             new Priority() { PriorityName = "Medium"},
             new Priority() { PriorityName = "Low"}

            };
        }


    }
}
