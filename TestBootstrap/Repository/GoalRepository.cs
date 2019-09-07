using DiaryAppOlga.Models;
using System.Collections.Generic;
using System.Linq;


namespace DiaryAppOlga.Repository
{
    public class GoalRepository:IDataRepository<Goal>
    {
        private GeneralScheduleContext context;

        public GoalRepository(GeneralScheduleContext ctx) => context = ctx;

        public IEnumerable<Goal> ListAll => context.Goals.ToArray();

        public Goal GetById(int key) => context.Goals.Find(key);

        public void Add(Goal goal)
        {
            this.context.Goals.Add(goal);
            this.context.SaveChanges();
        }

        public void Update(Goal goal)
        {
            context.Goals.Update(goal);
            context.SaveChanges();
        }

        public void Delete(Goal goal)
        {

            context.Goals.Remove(goal);
            context.SaveChanges();
        }


    }
}
