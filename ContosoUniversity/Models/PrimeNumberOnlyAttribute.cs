using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Models
{
    public class PrimeNumberOnly : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                int valueInteger;
                if (int.TryParse(value.ToString(), out valueInteger))
                {
                    if (IsPrime(valueInteger))
                    {
                        return ValidationResult.Success;
                    }
                    else
                    {
                        return new ValidationResult(string.Concat(validationContext.DisplayName, " is not a prime number"));
                    }
                }
                else
                {
                    return new ValidationResult(string.Concat(validationContext.DisplayName, " must be an integer"));
                }
            }
            return ValidationResult.Success;
        }

        private bool IsPrime(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

    }
}