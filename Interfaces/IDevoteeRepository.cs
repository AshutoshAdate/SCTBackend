using SreeChintamaniTrustBackend.Models;

namespace SreeChintamaniTrustBackend.Interfaces
{
    public interface IDevoteeRepository
    {
        Task<IEnumerable<Devotee>> GetAllDevotees();
        Task<Devotee?> GetDevoteeById(int Id);
        Task<Devotee> AddDevotee(Devotee devotee);
    }
}
