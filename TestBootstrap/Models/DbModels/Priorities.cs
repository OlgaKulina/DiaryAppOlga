using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiaryAppOlga.Models.DbModels
{
    public class Priorities: BaseEntity
    {
        
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
