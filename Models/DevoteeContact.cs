using System.ComponentModel.DataAnnotations;

namespace SreeChintamaniTrustBackend.Models
{
    public class DevoteeContact
    {
        [Key]
        public int DevoteeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public long MobileNo { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
