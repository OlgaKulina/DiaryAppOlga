using DiaryAppOlga.Models;
using System.Collections.Generic;
using System.Linq;


namespace DiaryAppOlga.Repository
{
    public class WeeklyScheduleRepository: IDataRepository<WeeklyTask>
    {
        private GeneralScheduleContext context;

        public WeeklyScheduleRepository(GeneralScheduleContext ctx) => context = ctx;        

        public IEnumerable<WeeklyTask> ListAll => context.WeeklyTasks.ToArray();

        public WeeklyTask GetById(int key) => context.WeeklyTasks.Find(key);

        public void Add(WeeklyTask weeklyTask)
        {
            this.context.WeeklyTasks.Add(weeklyTask);
            this.context.SaveChanges();
        }

        public void Update(WeeklyTask weeklyTask)
        {
            context.WeeklyTasks.Update(weeklyTask);
            context.SaveChanges();
        }

        public void Delete(WeeklyTask weeklyTask)
        {

            context.WeeklyTasks.Remove(weeklyTask);
            context.SaveChanges();
        }


    }
}
