using DiaryAppOlga.Models;
using System.Collections.Generic;


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
