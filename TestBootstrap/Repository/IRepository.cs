using DiaryAppOlga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiaryAppOlga.Repository
{
    public interface IRepository{

        IEnumerable<UserTask> UserTasks { get; }

        UserTask GetUserTask(int key);

        void AddUserTask(UserTask userTask);

        void UpdateUserTask(UserTask userTask);

        //void UpdateAllTask(MonthlyTask[] monthlyTasks);

        void DeleteUserTask(UserTask userTask);
    }
}
