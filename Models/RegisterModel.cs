using System.ComponentModel.DataAnnotations;
using IssueTracker.Data;

namespace IssueTracker.Models
{
    public class RegisterModel
    {

         [Required]
         [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage ="First Name required")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
       
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public UserType userType { get; set; }
    }
}