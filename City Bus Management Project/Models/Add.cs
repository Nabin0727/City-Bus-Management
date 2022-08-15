using System.ComponentModel.DataAnnotations;

namespace City_Bus_Management_Project.Models
{
    public class Add
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string VName { get; set; }

        [Required]
        public int Vno { get; set; }

        [Required] 
        public int Did { get; set; }

        [Required]
        public int Rno { get; set; }

    }
}
