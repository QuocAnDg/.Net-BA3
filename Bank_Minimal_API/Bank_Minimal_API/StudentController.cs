using Microsoft.AspNetCore.Mvc;
using Bank_Minimal_API;

namespace Bank_Minimal_API
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static List<Student> _students = new List<Student>()
    {
        new Student (1,"Paul", "Ochon",new DateTime(1950, 12, 1)),
        new Student (2, "Daisy", "Drathey", new DateTime(1970, 12, 1)),
        new Student (3, "Elie", "Coptaire",new DateTime(1980, 12, 1))
    };

        [HttpGet]
        public List<Student> GetStudents()
        {
            return _students;
        }
        [HttpPost]
        public Student addStudent(String FirstName, String LastName, DateTime birthday)
        {
            Student newStudent = new Student(_students.Count+1, FirstName, LastName, birthday);
            _students.Add(newStudent);
            return newStudent;
        }
        [HttpGet("{id}")]
        public ActionResult<Student> GetById(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return student;
        }
    }
}
