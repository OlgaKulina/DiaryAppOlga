using System.Collections.Generic;


namespace DiaryAppOlga.Models.DbModels
{
    public class DailyPlan : BaseEntity
    {


        //public List <Day> Days { get; private set; }

        private static List<Day> CreateListDays()
        {
            return new List<Day>
            {
                { new Day(){DayNumber=1} }, { new Day(){DayNumber=2} },{ new Day(){DayNumber=3}},
                { new Day(){DayNumber=4} }, { new Day(){DayNumber=5} },{ new Day(){DayNumber=6}},
                { new Day(){DayNumber=7} }, { new Day(){DayNumber=8} },{ new Day(){DayNumber=9}},
                { new Day(){DayNumber=10} },{ new Day(){DayNumber=11}},{ new Day(){DayNumber=12}},
                { new Day(){DayNumber=13} },{ new Day(){DayNumber=14}},{ new Day(){DayNumber=15}},
                { new Day(){DayNumber=16} },{ new Day(){DayNumber=17}},{ new Day(){DayNumber=18}},
                { new Day(){DayNumber=19} },{ new Day(){DayNumber=20}},{ new Day(){DayNumber=21}},
                { new Day(){DayNumber=22} },{ new Day(){DayNumber=23}},{ new Day(){DayNumber=24}},
                { new Day(){DayNumber=25} },{ new Day(){DayNumber=26}},{ new Day(){DayNumber=27}},
                { new Day(){DayNumber=28} },{ new Day(){DayNumber=29}},{ new Day(){DayNumber=30}}
            };

        }


        public WeeklyPlan WeeklyPlan { get; set; }






        //private List<Day> days = new List<Day>(30);

        //days.Add()

        //private List<Day> days = new List<Day>(30);
        //days.Add(new Day() { DayNumber = "1"})

        //public DailyPlan(int Id, IEnumerable<Day> days) : this(Id)
        //{
        //    //private List<Day> days = new List<Day>(30);
        //    Days = new List<Day>(days);
        //}

        //List<Day> days = List<Day>() 
        //    {
        //   new Day(1),
        //    new Day(2),
        //    new Day(3)
        //    };


    }
}

