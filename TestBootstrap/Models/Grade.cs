using System.Collections.Generic;

namespace DiaryAppOlga.Models
{
    //change - create collection
    public class Grade
    {
       
        public int Grade_Id { get; set; }
        public string GradeName { get; set; }
        
        
        static IEnumerable<Grade> GetGrades()
        {
            return new List<Grade>()
            {
                new Grade(){ GradeName="5"},
                new Grade(){ GradeName="4"},
                new Grade(){ GradeName="3"},
                new Grade(){ GradeName="2"},
                new Grade(){ GradeName="1"}
            };
        }
        
    }
}
