using System.ComponentModel.DataAnnotations;
using IssueTracker.Data;

namespace IssueTracker.Models
{
    public class RegisterModel
    {

        [Required]
        public string UserName { get; set; }
         [Required]
         [EmailAddress]
        public string Email { get; set; }    
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public UserType UserType { get; set; }
    }
}