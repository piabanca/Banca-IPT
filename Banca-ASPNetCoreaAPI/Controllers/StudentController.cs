using Microsoft.AspNetCore.Mvc;

namespace StudentInfoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private string Fullname = "Pia V. Banca";
        private string idNo = "24-0977";
        private string program = "BSIT";
        private string birthdate = "09-27-05";
        private string age = "20";


        [HttpGet("Fullname")]
        public IActionResult GetFullname()
        {
            try
            {
                return Ok(Fullname);
            }
            catch (Exception ex)
            {
                return BadRequest("Error: " + ex.Message);
            }
        }


        [HttpGet("idno")]
        public IActionResult GetIdNo()
        {
            try
            {
                return Ok(idNo);
            }
            catch (Exception ex)
            {
                return BadRequest("Error: " + ex.Message);
            }
        }


        [HttpGet("program")]
        public IActionResult GetProgram()
        {
            try
            {
                return Ok(program);
            }
            catch (Exception ex)
            {
                return BadRequest("Error: " + ex.Message);
            }
        }

        [HttpGet("birthdate")]
        public IActionResult GetBirthdate()
        {
            try
            {
                return Ok(birthdate);
            }
            catch (Exception ex)
            {
                return BadRequest("Error: " + ex.Message);
            }
        }

        [HttpGet("age")]
        public IActionResult GetAge()
        {
            try
            {
                return Ok(age);
            }
            catch (Exception ex)
            {
                return BadRequest("Error: " + ex.Message);
            }
        }

        [HttpPost("Fullname")]
        public IActionResult SetFulltime([FromBody] string fullname)
        {
            try
            {
                return Ok("Fullname Updated to: " + fullname);
            }
            catch (Exception ex)
            {
                return BadRequest("Error: " + ex.Message);
            }
        }

        [HttpPost("idno")]
        public IActionResult SetIdNo([FromBody] string idno)
        {
            try
            {
                return Ok("ID Number Updated to: " + idno);
            }
            catch (Exception ex)
            {
                return BadRequest("Error: " + ex.Message);
            }
        }

        [HttpPost("program")]
        public IActionResult SetProgram([FromBody] string program)
        {
            try
            {
                return Ok("Program Updated to: " + program);
            }
            catch (Exception ex)
            {
                return BadRequest("Error: " + ex.Message);
            }
        }

        [HttpPost("birthdate")]
        public IActionResult SetBirthdate([FromBody] string birthdate)
        {
            try
            {
                return Ok("Birthdate Updated to: " + birthdate);
            }
            catch (Exception ex)
            {
                return BadRequest("Error: " + ex.Message);
            }
        }
    }
}