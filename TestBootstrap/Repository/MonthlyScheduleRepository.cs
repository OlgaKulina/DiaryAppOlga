using DiaryAppOlga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiaryAppOlga.Repository
{
    public class MonthlyScheduleRepository :  IDataRepository<MonthlyTask>
    {
        private GeneralScheduleContext context;

        public MonthlyScheduleRepository(GeneralScheduleContext ctx) => context = ctx;

        public IEnumerable<MonthlyTask> ListAll => context.MonthlyTasks.ToArray();        

        public MonthlyTask GetById(int key) => context.MonthlyTasks.Find(key);

        public void Add(MonthlyTask monthlyTask)
        {
            this.context.MonthlyTasks.Add(monthlyTask);
            this.context.SaveChanges();
        }

        public void Update(MonthlyTask monthlyTask)
        {
            context.MonthlyTasks.Update(monthlyTask);
            context.SaveChanges();
        }

        public void Delete(MonthlyTask monthlyTask)
        {

            context.MonthlyTasks.Remove(monthlyTask);
            context.SaveChanges();
        }




    }
}
