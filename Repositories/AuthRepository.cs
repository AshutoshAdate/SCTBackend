using Microsoft.EntityFrameworkCore;
using SreeChintamaniTrustBackend.Data;
using SreeChintamaniTrustBackend.Helper;
using SreeChintamaniTrustBackend.Interfaces;
using SreeChintamaniTrustBackend.Models.DTO;

namespace SreeChintamaniTrustBackend.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly authHelper _authHelper;

        public AuthRepository(AppDbContext appDbContext, authHelper authHelper)
        {
            _appDbContext = appDbContext;
            _authHelper = authHelper;
        }

        public async Task<UserResponseDto> Login(UserRequestDto userRequest)
        {

            // Find user by username (not by primary key)
            var user = await _appDbContext.Devotees
                                          .FirstOrDefaultAsync(d => d.Username == userRequest.Username);

            if (user == null)
                return new UserResponseDto
                {
                    Message = "Invalid User"
                };

            if (user == null || !_authHelper.VerifyPassword(userRequest.Password!, user.Password))
            {
                return new UserResponseDto
                {
                    Message = "Invalid username or password.",
                    Token = string.Empty
                };
            }
            // Optionally validate password here if required

            // Generate JWT token
            var token = _authHelper.GenerateToken(userRequest.Username!, userRequest.Password!);

            var rsponse = new UserResponseDto
            {
                Message = "Logged in Successfully",
                Username = userRequest.Username,
                Token = token,
            };

            return rsponse;
        }

    }
}
