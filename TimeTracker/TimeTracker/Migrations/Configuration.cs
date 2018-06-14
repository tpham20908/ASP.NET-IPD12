namespace TimeTracker.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using TimeTracker.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TimeTracker.Models.TimeTrackerDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TimeTracker.Models.TimeTrackerDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.TimeCards.RemoveRange(context.TimeCards);
            context.Employees.RemoveRange(context.Employees);

            IList<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee()
            {
                FirstName = "Tung",
                LastName = "Pham",
                Department = "IT",
                Role = "Developer",
                TimesCards = new List<TimeCard>()
                {
                    new TimeCard
                    {
                        ID = 1,
                        SubmissionDate = DateTime.Now,
                        MondayHours = 8,
                        TuesdayHours = 6,
                        WednesdayHours = 8,
                        ThursdayHours = 5,
                        FridayHours = 7,
                        SaturdayHours = 0,
                        SundayHours = 2
                    },
                    new TimeCard
                    {
                        ID = 2,
                        SubmissionDate = DateTime.Now.AddDays(-3),
                        MondayHours = 4,
                        TuesdayHours = 7,
                        WednesdayHours = 7,
                        ThursdayHours = 5,
                        FridayHours = 6,
                        SaturdayHours = 3,
                        SundayHours = 3
                    }
                }
            });

            Employees.Add(new Employee()
            {
                FirstName = "Peter",
                LastName = "Parker",
                Department = "Sale",
                Role = "Clerk",
                TimesCards = new List<TimeCard>()
                {
                    new TimeCard
                    {
                        ID = 3,
                        SubmissionDate = DateTime.Now.AddDays(-5),
                        MondayHours = 4,
                        TuesdayHours = 6,
                        WednesdayHours = 8,
                        ThursdayHours = 5,
                        FridayHours = 7,
                        SaturdayHours = 0,
                        SundayHours = 2
                    },
                    new TimeCard
                    {
                        ID = 4,
                        SubmissionDate = DateTime.Now,
                        MondayHours = 4,
                        TuesdayHours = 7,
                        WednesdayHours = 7,
                        ThursdayHours = 7,
                        FridayHours = 6,
                        SaturdayHours = 0,
                        SundayHours = 0
                    }
                }
            });

            context.Employees.AddRange(Employees);
            base.Seed(context);
        }
    }
}
