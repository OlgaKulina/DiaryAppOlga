using System.Collections.Generic;


namespace DiaryAppOlga.Models.DbModels
{
    public class TGrade : BaseEntity
    {
        public string GradeName { get; set; }
        public string Smile { get; set; }

        private static IEnumerable<TGrade> GetGrades()
        {
            return new List<TGrade>()
            {
                new TGrade(){ GradeName="5", Smile="~/wwwroot/img/imgSmiles/laugh5.png"},
                new TGrade(){ GradeName="4", Smile="~/wwwroot/img/imgSmiles/happy4.png"},
                new TGrade(){ GradeName="3", Smile="~/wwwroot/img/imgSmiles/neutral3.png"},
                new TGrade(){ GradeName="2", Smile="~/wwwroot/img/imgSmiles/sad2.png"},
                new TGrade(){ GradeName="1", Smile="~/wwwroot/img/imgSmiles/cry1.png"}
            };
        }

    }
}
