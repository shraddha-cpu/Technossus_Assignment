using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Technossus_Assignment.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Student_Name is required")]

        public string Student_Name { get; set; }

        [Required(ErrorMessage = "Student_Father_Name is required")]
        public string Student_Father_Name { get; set; }

        [Required(ErrorMessage = "Student_Mother_Name is required")]
        public string Student_Mother_Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "email is required")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required(ErrorMessage = "registrationdate is required")]

        public string registrationdate { get; set; }


        [Required(ErrorMessage = "HomeAddress is required")]
        public string HomeAddress { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [ScaffoldColumn(false)]
        public int IsActive { get; set; }
    }
}
