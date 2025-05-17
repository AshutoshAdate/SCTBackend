using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SreeChintamaniTrustBackend.Interfaces;
using SreeChintamaniTrustBackend.Models;

namespace SreeChintamaniTrustBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DevoteeController : ControllerBase
    {
        private readonly IDevoteeRepository _devoteeRepository;

        public DevoteeController(IDevoteeRepository devoteeRepository)
        {
            _devoteeRepository = devoteeRepository;
        }

        [Authorize]
        [HttpGet("GetAllDevotees")]
        public async Task<ActionResult<IEnumerable<Devotee>>> GetDevotees()
        {
            var devotees = await _devoteeRepository.GetAllDevotees();
            return Ok(devotees);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Devotee>> GetUser(int id)
        {
            var user = await _devoteeRepository.GetDevoteeById(id);
            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<Devotee>> AddDevotee(Devotee devotee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var createdUser = await _devoteeRepository.AddDevotee(devotee);
            return Ok();//CreatedAtAction(nameof(GetUser), new { id = createdUser.Id }, createdUser);
        }
    }
}
