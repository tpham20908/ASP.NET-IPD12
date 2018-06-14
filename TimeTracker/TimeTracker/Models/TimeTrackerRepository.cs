using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeTracker.Models
{
    public class TimeTrackerRepository
    {
        public TimeTrackerDBContext context = new TimeTrackerDBContext();
        // get all employees
        public List<Employee> GetEmployees()
        {
            return context.Employees.ToList();
        }

        // get all timecards of selected employee
        public List<TimeCard> GetTimeCards(int empId)
        {
            List<TimeCard> timeCards = (from e in context.Employees
                                        where e.ID == empId
                                        select e.TimesCards).FirstOrDefault();

            //List<TimeCard> timeCards = context.Employees
            //    .Where(e => e.ID == empId)
            //    .Select(e => e.TimesCards);

            return timeCards;
        }
    }
}