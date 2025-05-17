using SreeChintamaniTrustBackend.Models;

namespace SreeChintamaniTrustBackend.Interfaces
{
    public interface IContactUsRepository
    {
        Task<DevoteeContact> AddDevoteeContact(DevoteeContact devoteeContact);
    }
}
