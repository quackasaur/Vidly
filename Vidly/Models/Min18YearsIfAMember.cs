using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Vidly.Dtos;

namespace Vidly.Models
{
    public class Min18YearsIfAMember: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // will be called at savechanges
            var customer = (Customer) validationContext.ObjectInstance;

            if (customer.MembershipTypeId == Customer.Unknown || customer.MembershipTypeId == Customer.PayAsYouGo)
            {
                return ValidationResult.Success;
            }

            if (customer.Birthdate == null)
            {
                return new ValidationResult("Birthdate is required");
            }

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age > 17) ? ValidationResult.Success : new ValidationResult("Should be atleast 18 years old for subscription");

        }
    }
}