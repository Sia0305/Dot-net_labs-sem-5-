using System.ComponentModel.DataAnnotations;
using Xunit;

namespace lab_7.Model
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Range(1, 50, ErrorMessage = "Age must be between 1 and 50")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Subject is required")] 
        public string Subject { get; set; }
    }
}
