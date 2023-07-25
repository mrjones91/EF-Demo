using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EF_MVC_Demo.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
