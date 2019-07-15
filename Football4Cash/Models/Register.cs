using System;
using System.ComponentModel.DataAnnotations;

namespace Football4Cash.Models
{
    public class Register
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        //find out if we should make (you remeber to expose private fields) maybe 4-30 char password validation
        [MinLength(5,ErrorMessage = "Password must be 5 characters greater.")]
        public string Password { get; set; }
    }
}
