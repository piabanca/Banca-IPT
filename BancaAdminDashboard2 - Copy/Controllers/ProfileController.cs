using Microsoft.AspNetCore.Mvc;

namespace BancaAdminDashboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        private string Fullname = "Pia V. Banca";
        private string Program = "BSIT";
        private string Age = "20";
        private string Address = "Parang, Maguindanao";
        private string Email = "banca.piheu24@southernchristiancollege.edu.ph";

        [HttpGet("Fullname")]
        public IActionResult GetFullname()
        {
            try { return Ok(Fullname); }
            catch (Exception ex) { return BadRequest("Error: " + ex.Message); }
        }

        [HttpGet("Program")]
        public IActionResult GetProgram()
        {
            try { return Ok(Program); }
            catch (Exception ex) { return BadRequest("Error: " + ex.Message); }
        }

        [HttpGet("Age")]
        public IActionResult GetAge()
        {
            try { return Ok(Age); }
            catch (Exception ex) { return BadRequest("Error: " + ex.Message); }
        }

        [HttpGet("Address")]
        public IActionResult GetAddress()
        {
            try { return Ok(Address); }
            catch (Exception ex) { return BadRequest("Error: " + ex.Message); }
        }

        [HttpGet("Email")]
        public IActionResult GetEmail()
        {
            try { return Ok(Email); }
            catch (Exception ex) { return BadRequest("Error: " + ex.Message); }
        }
    }
}