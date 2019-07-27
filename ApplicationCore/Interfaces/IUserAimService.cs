using Microsoft.DiaryAppOlga.ApplicationCore.Entities;
using System.Threading.Tasks;

namespace Microsoft.DiaryAppOlga.ApplicationCore.Interfaces
{
    public interface IUserAimService
    {
        Task CreateUserAimAsync(int UserId);
    }
}
