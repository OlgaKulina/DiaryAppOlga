
using System;
using System.ComponentModel.DataAnnotations;

namespace DiaryAppOlga.Models
{
    public class MonthlyTask
    {
        public int MonthlylyTask_Id { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }


        public int UserTask_Id { get; set; }
        public UserTask UserTask { get; set; }


        //public int Grade_Id { get; set; }


        //Create a method that validates date input



    }
}
