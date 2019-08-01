using Microsoft.DiaryAppOlga.ApplicationCore.Interfaces;

namespace Microsoft.DiaryAppOlga.ApplicationCore.Entities
{
    public class Priority : BaseEntity, IAggregateRoot
    {
        public string PriorityName { get; set; }
    }
}
