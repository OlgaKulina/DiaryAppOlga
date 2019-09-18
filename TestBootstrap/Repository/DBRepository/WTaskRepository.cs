using DiaryAppOlga.Models.DbModels;

namespace DiaryAppOlga.Repository.DBRepository
{
    public class WTaskRepository: GenRepository<WTask>
    {
        public WTaskRepository(DatabaseContext dbcontext) : base(dbcontext)
        {

        }


    }
}
