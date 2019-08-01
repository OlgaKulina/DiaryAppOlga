using Microsoft.DiaryAppOlga.ApplicationCore.Interfaces;

namespace Microsoft.DiaryAppOlga.ApplicationCore.Entities
{
    public class Grade : BaseEntity, IAggregateRoot
    {
        public string GradeName { get; set; }
        public string Picture { get; set; }
    }
}
