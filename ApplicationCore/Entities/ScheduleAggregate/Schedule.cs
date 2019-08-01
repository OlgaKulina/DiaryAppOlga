using Microsoft.DiaryAppOlga.ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.DiaryAppOlga.ApplicationCore.Entities.ScheduleAggregate
{
    public class Schedule : BaseEntity, IAggregateRoot
    {
        public int UserId { get; set; }


    }
}
