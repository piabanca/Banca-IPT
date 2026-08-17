using Microsoft.AspNetCore.Mvc;
using FirstWebAPIpractice;
namespace FirstWebAPIpractice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsControllers : ControllerBase
    {
        [HttpGet]
        public ActionResult GetStudents()
        {
            var students = new List<Student>
            { 
                new Student { Id = 1, Name = "Pia", Course = "BSIT" },
                new Student { Id = 2, Name = "Mira",Course = "BSIT" },
                new Student { Id = 3, Name = "Joy", Course = "BSIT" },
             };

            return Ok(students);
        }
    }
}
