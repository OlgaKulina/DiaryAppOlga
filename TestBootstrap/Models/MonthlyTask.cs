
using System;
using System.ComponentModel.DataAnnotations;

namespace DiaryAppOlga.Models
{
    public class MonthlyTask
    {
        public int Id { get; set; }


        public int UserTask_Id { get; set; }
        public UserTask UserTask { get; set; }


        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime StartDate { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime EndDate { get; set; }








        //Create a method that validates date input



    }
}
