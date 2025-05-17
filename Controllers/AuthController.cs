using Microsoft.AspNetCore.Mvc;
using SreeChintamaniTrustBackend.Interfaces;
using SreeChintamaniTrustBackend.Models.DTO;

namespace SreeChintamaniTrustBackend.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("Login")]
        public ActionResult<Task<UserResponseDto>> Login([FromBody] UserRequestDto userRequest)
        {
            var token = _authRepository.Login(userRequest);
            return Ok(new { Token = token });
        }
    }
}
