using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SreeChintamaniTrustBackend.Interfaces;
using SreeChintamaniTrustBackend.Models;

namespace SreeChintamaniTrustBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactUsController : ControllerBase
    {
        private readonly IContactUsRepository contactUsRepository;

        public ContactUsController(IContactUsRepository contactUsRepository)
        {
            this.contactUsRepository = contactUsRepository;
        }

        [HttpPost("adContact")]
        //[Authorize]

        public async Task<ActionResult<DevoteeContact>> AddDevoteeContact(DevoteeContact devoteeContact)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var savedContact = await contactUsRepository.AddDevoteeContact(devoteeContact);
            return Ok(savedContact);
        }

    }
}
