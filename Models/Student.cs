using System.ComponentModel.DataAnnotations;

namespace Student_IMS.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Surname is required")]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Student number is required")]
        [Display(Name="Student Number")]
        public int StudentNumber { get; set; }
        [Range(17,50, ErrorMessage ="Age must be between 17 and 50")]
        public int Age { get; set; }
    }
}
