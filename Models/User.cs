using System.ComponentModel.DataAnnotations;

namespace FormValidation.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        [Display(Name = "First name:")] 
        public string FirstName {get;set;}
        [Required]
        [MinLength(4)]
        [Display(Name = "Last name:")] 
        public string LastName {get;set;}
        [Required]
        [Range(0,999)]
        public int Age {get;set;}
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        [Required]
        [DataType(DataType.Password)]
        public string Password {get;set;}
    }
}