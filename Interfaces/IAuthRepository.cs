using SreeChintamaniTrustBackend.Models.DTO;

namespace SreeChintamaniTrustBackend.Interfaces
{
    public interface IAuthRepository
    {
        Task<UserResponseDto> Login(UserRequestDto userRequest);
    }
}
