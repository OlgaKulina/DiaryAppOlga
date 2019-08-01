
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.DiaryAppOlga.ApplicationCore.Interfaces
{
    public interface IScheduleService
    {
        Task CreateScheduleAsync(int scheduleId, int dailyTaskId, int weeklyTaskId, int monthlyTaskId);


    }
}
