
using DiaryAppOlga.Models;
using System.Collections.Generic;
using System.Linq;


namespace DiaryAppOlga.Repository
{
    public class ScheduleRepository: IRepository {

        private ScheduleContext context;

        public ScheduleRepository(ScheduleContext ctx) => context = ctx;

        public IEnumerable<UserTask> UserTasks => context.UserTasks.ToArray();

        public UserTask GetUserTask(int key) => context.UserTasks.Find(key);

        public void AddUserTask(UserTask userTask)
        {
            this.context.UserTasks.Add(userTask);
            this.context.SaveChanges();
        }

        //public void AddMonthlyTask(MonthlyTask monthlyTask)
        //{
        //    this.context.MonthlyTask.Add(monthlyTask);
        //    this.context.SaveChanges();
        //}



        public void UpdateUserTask(UserTask userTask)
        {
            context.UserTasks.Update(userTask);
            context.SaveChanges();
        }

        public void DeleteUserTask(UserTask userTask) {

            context.UserTasks.Remove(userTask);
            context.SaveChanges();
        }

    }

}

