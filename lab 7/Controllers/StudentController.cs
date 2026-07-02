using lab_7.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab_7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "John Doe", Age = 20 , Subject = "DAA"},
            new Student { Id = 2, Name = "Jane Smith", Age = 22 , Subject = "CN"},
            new Student { Id = 3, Name = "Michael Johnson", Age = 21 , Subject = ".NET"}
        };


        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student updatedStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound("Student not found");
            }

            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;

            return Ok(student);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound("Student not found");
            }
            students.Remove(student);
            return Ok("Student deleted successfully");
        }

        [HttpPost("{id}")]
        public IActionResult CreateStudent(Student student)
        {
            students.Add(student);
            return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
        }
    }
}
