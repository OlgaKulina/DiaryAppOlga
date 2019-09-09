using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiaryAppOlga.Models.DbModels
{
    public class Week: BaseEntity
    {
        
        List<DTask> dTasks = new List<DTask>(7);

    }
}
