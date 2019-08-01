using Microsoft.DiaryAppOlga.ApplicationCore.Entities.ScheduleAggregate;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IMonthlyTasksService
    {
        Task CreateMonthlyTaskAsync(int monthlyTaskId, int scheduleId);
    }
}
