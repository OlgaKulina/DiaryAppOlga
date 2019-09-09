using DiaryAppOlga.Models;
using System.Collections.Generic;
using System.Linq;


namespace DiaryAppOlga.Repository
{
    public class GoalRepository:IDataRepository<Goals>
    {
        private GeneralScheduleContext context;

        public GoalRepository(GeneralScheduleContext ctx) => context = ctx;

        public IEnumerable<Goals> ListAll => context.Goals.ToArray();
        
        public Goals GetById(int key) => context.Goals.Find(key);

        public void Add(Goals goal)
        {
            this.context.Goals.Add(goal);
            this.context.SaveChanges();
        }

        public void Update(Goals goal)
        {
            context.Goals.Update(goal);
            context.SaveChanges();
        }

        public void Delete(Goals goal)
        {

            context.Goals.Remove(goal);
            context.SaveChanges();
        }


    }
}
