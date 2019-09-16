using System.Collections.Generic;


namespace DiaryAppOlga.Models.DbModels
{
    public class Day : BaseEntity
    {
        public int DayNumber { get; set; }
        public virtual List<DTask> DTasks { get; set; }
                            
        
    }
}
