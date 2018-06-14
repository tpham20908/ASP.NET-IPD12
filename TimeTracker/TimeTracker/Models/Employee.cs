using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TimeTracker.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required, MaxLength(100)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }

        public List<TimeCard> TimesCards { get; set; }
    }
}