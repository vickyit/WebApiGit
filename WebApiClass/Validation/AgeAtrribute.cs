using System.ComponentModel.DataAnnotations;

namespace WebApiClass.Validation
{ 
    public class AgeAtrribute:ValidationAttribute
    {

        private readonly int _age;
        public AgeAtrribute(int age)
        {
            _age = age;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
             if(value is DateTime date)
            {
                var currentAge = DateTime.Today.Year -date.Year;

                if(currentAge >= _age)
                //if(currentAge >=21)
                {
                    return ValidationResult.Success;
                }

            }

            return new ValidationResult("error.........");
        }
    }
}
