using System.Collections.Generic;
using System.Resources;

namespace DiaryAppOlga.Models
{
    //change - create collection
    public class Grade
    {
       
        public int Grade_Id { get; set; }
        public string GradeName { get; set; }
        public string Smile { get; set; }

        static IEnumerable<Grade> GetGrades()
        {
            return new List<Grade>()
            {
                new Grade(){ GradeName="5", Smile="~/img/imgSmiles/laugh5.png"},
                new Grade(){ GradeName="4", Smile="~/img/imgSmiles/happy4.png"},
                new Grade(){ GradeName="3", Smile="~/img/imgSmiles/neutral3.png"},
                new Grade(){ GradeName="2", Smile="~/img/imgSmiles/sad2.png"},
                new Grade(){ GradeName="1", Smile="C:/Users/GT/source/repos/TestBootstrap/TestBootstrap/wwwroot/img/imgSmiles/cry1.png"}
            };
        }
        
    }
}
