using System.ComponentModel.DataAnnotations;

namespace City_Bus_Management_Project.Models
{
    public class Login
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public float Password { get; set; }


    }
}