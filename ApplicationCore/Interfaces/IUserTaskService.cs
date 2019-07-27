
using System.Threading.Tasks;

namespace Microsoft.DiaryAppOlga.ApplicationCore.Interfaces
{
    public interface IUserTaskService
    {
        Task CreateTaskAsync(int UserId);
    }
}
