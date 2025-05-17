using SreeChintamaniTrustBackend.Data;
using SreeChintamaniTrustBackend.Interfaces;
using SreeChintamaniTrustBackend.Models;

namespace SreeChintamaniTrustBackend.Repositories
{
    public class ContactUsRepository : IContactUsRepository
    {
        private readonly AppDbContext _appDbContext;

        public ContactUsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<DevoteeContact> AddDevoteeContact(DevoteeContact devoteeContact)
        {
            _appDbContext.DevoteeContacts.Add(devoteeContact);
            await _appDbContext.SaveChangesAsync();
            return devoteeContact;
        }
    }
}
