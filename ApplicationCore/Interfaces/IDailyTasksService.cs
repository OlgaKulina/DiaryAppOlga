using Microsoft.DiaryAppOlga.ApplicationCore.Entities.ScheduleAggregate;
using System.Threading.Tasks;

namespace Microsoft.DiaryAppOlga.ApplicationCore.Interfaces
{
    public interface IDailyTasksService
    {
        Task CreateDailyTaskAsync(int dailyTaskId, int scheduleId);
    }
}
