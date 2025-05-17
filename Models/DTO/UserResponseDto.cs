namespace SreeChintamaniTrustBackend.Models.DTO
{
    public record UserResponseDto
    {
        public string? Username { get; init; }
        public string? Token { get; init; }
        public string? Message { get; init; }

    }
}
