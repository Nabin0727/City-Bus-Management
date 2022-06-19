using System.ComponentModel.DataAnnotations;
namespace City_Bus_Management_Project.Models
{
    public class Signup
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string driverId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Bno { get; set; }



        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string confirmPassword { get; set; }

    




    }
}