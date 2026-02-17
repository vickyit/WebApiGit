using System.ComponentModel.DataAnnotations;
using WebApiClass.Validation;

namespace WebApiClass.Models
{

    public class TestDto
    {
        [MinLength(6)]
        [StringLength(10, MinimumLength =6, ErrorMessage ="message")]
         public string Name { get; set; }


        [Compare("Name", ErrorMessage ="same As Name")]
        public string NameCopy { get; set; }



        [Required(ErrorMessage ="Email is Required!....")]
        [EmailAddress]
        public string Email { get; set; }


        [Range(10,100)]
        public int Value { get; set; }


        //[Url]
        public string Url { get; set; }


        [RegularExpression(@"[A-Z]{3}[0-9]{3}$")] 
        public string newValue { get; set; }

        [AgeAtrribute(18)]
        public DateTime DOB { get; set; }
    }
}
