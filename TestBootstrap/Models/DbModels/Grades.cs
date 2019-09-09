using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiaryAppOlga.Models.DbModels
{
    public class Grades : BaseEntity
    {
        public string GradeName { get; set; }
        public string Smile { get; set; }

        static IEnumerable<Grade> GetGrades()
        {
            return new List<Grade>()
            {
                new Grade(){ GradeName="5", Smile="~/wwwroot/img/imgSmiles/laugh5.png"},
                new Grade(){ GradeName="4", Smile="~/wwwroot/img/imgSmiles/happy4.png"},
                new Grade(){ GradeName="3", Smile="~/wwwroot/img/imgSmiles/neutral3.png"},
                new Grade(){ GradeName="2", Smile="~/wwwroot/img/imgSmiles/sad2.png"},
                new Grade(){ GradeName="1", Smile="~/wwwroot/img/imgSmiles/cry1.png"}
            };
        }

    }
}
