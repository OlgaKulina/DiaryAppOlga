using Microsoft.DiaryAppOlga.ApplicationCore.Entities.ScheduleAggregate;
using System.Threading.Tasks;

namespace Microsoft.DiaryAppOlga.ApplicationCore.Interfaces
{
    public interface IWeeklyTasksService
    {
        Task CreateWeeklyTaskAsync(int weeklyTaskId, int scheduleId);
    }
}
