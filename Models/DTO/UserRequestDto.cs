namespace SreeChintamaniTrustBackend.Models.DTO
{
    public record UserRequestDto
    {
        public string? Username { get; init; }
        public string? Password { get; init; }
    }
}
