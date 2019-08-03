using Microsoft.DiaryAppOlga.ApplicationCore.Entities;
using System;
using System.Collections.Generic;


namespace Microsoft.DiaryAppOlga.Infrastructure.Data
{
    public class ScheduleContextSeed
    {

        static IEnumerable<Priority> GetPreconfiguredPriorities()
        {            
            return new List<Priority>()
            {
             new Priority() { PriorityName="High"},
             new Priority() { PriorityName = "Medium"},
             new Priority() { PriorityName = "Low"}

            };
        }

        static IEnumerable<Grade> GetPreconfiguredGrades()
        {
            return new List<Grade>()
            {
                new Grade(){ GradeName="5"},
                new Grade(){ GradeName="4"},
                new Grade(){ GradeName="3"},
                new Grade(){ GradeName="2"},
                new Grade(){ GradeName="1"}
            };
        }
    }

}
