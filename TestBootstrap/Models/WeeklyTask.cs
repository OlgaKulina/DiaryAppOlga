using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiaryAppOlga.Models
{
    public class WeeklyTask
    {
        
        public int Id { get; set; }
        

        static IEnumerable<WeekNumber> GetWeeklyNumber()
        {
            return new List<WeekNumber> ()
            {
             new WeekNumber() { WeekNumberName ="First"},
             new WeekNumber() { WeekNumberName = "Second"},
             new WeekNumber() { WeekNumberName = "Third"},
             new WeekNumber() { WeekNumberName = "Third"}
            };
        }

        public class WeekNumber
        {
            public string WeekNumberName { get; internal set; }
        }


        //[Required(ErrorMessage = "Set start date")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime Start_date { get; set; }

        //[Required(ErrorMessage = "Set end date")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime End_date { get; set; }


        public int UserTask_Id { get; set; }
        public UserTask UserTask { get; set; }

    }
}
