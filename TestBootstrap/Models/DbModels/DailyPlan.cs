using System.Collections.Generic;


namespace DiaryAppOlga.Models.DbModels
{
    public class DailyPlan: BaseEntity
    {
        List<Day> days = new List<Day>(30);
        //days.Add(new Day() { DayNumber="1"})

        //List<Person> people = new List<Person>(3);
        //people.Add(new Person() { Name = "Том" });
        //    people.Add(new Person() { Name = "Билл" })
    }
}
