using Microsoft.AspNetCore.Mvc;

namespace BancaWebAppProfile.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase    // The profilecontroller is the endpoint of every data in the profile. The HttpGet method is used to retrieve data. 
    {
        // static para hindi mag-reset sa bawat request
        private static ProfileData profile = new ProfileData
        {
            FullName = "Pia V. Banca",
            Program = "BSIT",
            Bio = "To dream is to live and to pursue it is to keep on living",
            Location = "Parang, Maguindanao",
            Email = "banca27@gmail.com",
            Projects = 0,
            Followers = 0,
            Following = 0
        };

        // GET api/Profile  (kinukuha ng Profile.razor)
        [HttpGet]
        public IActionResult GetProfile()
        {
            try { return Ok(profile); }
            catch (Exception ex) { return BadRequest("Error: " + ex.Message); }
        } 

        // POST api/Profile  (para sa Save button)
        [HttpPost] 
        public IActionResult SaveProfile([FromBody] ProfileData updated)
        {
            try
            {
                if (updated == null)
                {
                    return BadRequest("Invalid profile data.");
                }

                profile.FullName = updated.FullName;
                profile.Program = updated.Program;
                profile.Bio = updated.Bio;
                profile.Location = updated.Location;
                profile.Email = updated.Email;
            
                return Ok(profile);
            }
            catch (Exception ex) { return BadRequest("Error: " + ex.Message); }
        }

        [HttpGet("FullName")]
        public IActionResult GetFullName()
        {
            try { return Ok(profile.FullName); }
            catch (Exception ex) { return BadRequest("Error: " + ex.Message); }
        }

        [HttpGet("Program")]
        public IActionResult GetProgram()
        {
            try { return Ok(profile.Program); }
            catch (Exception ex) { return BadRequest("Error: " + ex.Message); }
        }

        [HttpGet("Bio")]
        public IActionResult GetBio()
        {
            try { return Ok(profile.Bio); }
            catch (Exception ex) { return BadRequest("Error: " + ex.Message); }
        }

        [HttpGet("Location")]
        public IActionResult GetLocation()
        {
            try { return Ok(profile.Location); }
            catch (Exception ex) { return BadRequest("Error: " + ex.Message); }
        }

        [HttpGet("Email")]
        public IActionResult GetEmail()
        {
            try { return Ok(profile.Email); }
            catch (Exception ex) { return BadRequest("Error: " + ex.Message); }
        }

        [HttpGet("Projects")]
        public IActionResult GetProjects()
        {
            try { return Ok(profile.Projects); }
            catch (Exception ex) { return BadRequest("Error: " + ex.Message); }
        }

        [HttpGet("Followers")]
        public IActionResult GetFollowers()
        {
            try { return Ok(profile.Followers); }
            catch (Exception ex) { return BadRequest("Error: " + ex.Message); }
        }

        [HttpGet("Following")]
        public IActionResult GetFollowing()
        {
            try { return Ok(profile.Following); }
            catch (Exception ex) { return BadRequest("Error: " + ex.Message); }
        }
    }

    public class ProfileData
    {
        public string FullName { get; set; } = "";   // Stores data information 
        public string Program { get; set; } = "";
        public string Bio { get; set; } = "";
        public string Location { get; set; } = "";
        public string Email { get; set; } = "";
        public int Projects { get; set; }
        public int Followers { get; set; }
        public int Following { get; set; }
    }
}