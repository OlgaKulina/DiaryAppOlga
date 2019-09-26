
using DiaryAppOlga.Models.DbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiaryAppOlga.Repository.DBRepository
{
    public class DTaskRepository: GenRepository<DTask>
    {
        private readonly object dbcontext;

        public DTaskRepository(DatabaseContext dbcontext): base (dbcontext)
        {
            

        }

        



    }



        
    }
}
