using System;
using System.ComponentModel.DataAnnotations;

namespace VidPlace.Models
{
    public class Min18YearsIfMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            // if customer chooses "pay as you go" => no validation error
            if (customer.MembershipId == Membership.PayAsYouGo || customer.MembershipId == Membership.Unknown)
                return ValidationResult.Success;
            // customer chooses other plans
            if (customer.Birthdate == null)
                return new ValidationResult("The Birthdate is required for a paid plan");
            // calculate teh age
            var age = DateTime.Now.Year - customer.Birthdate.Value.Year;

            return age >= 18 ? ValidationResult.Success : new ValidationResult("Customer has to be 18+");
        }
    }
}