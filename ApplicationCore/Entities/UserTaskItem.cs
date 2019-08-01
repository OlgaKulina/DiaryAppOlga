using Microsoft.DiaryAppOlga.ApplicationCore.Interfaces;

namespace Microsoft.DiaryAppOlga.ApplicationCore.Entities
{
    public class UserTaskItem : BaseEntity, IAggregateRoot
    {
        public string TaskName { get; set; }
        public string Description { get; set; }        
        //public int UserTask_Id { get; set; } ???
        public int Priority_Id { get; set; }
        public Priority Priority { get; set; }
        public int Grade_Id { get; set; }
        public Grade Grade { get; set; }
        public bool Status { get; set; }

    }
}
