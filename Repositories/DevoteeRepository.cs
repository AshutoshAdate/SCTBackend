using Microsoft.EntityFrameworkCore;
using SreeChintamaniTrustBackend.Data;
using SreeChintamaniTrustBackend.Helper;
using SreeChintamaniTrustBackend.Interfaces;
using SreeChintamaniTrustBackend.Models;

namespace SreeChintamaniTrustBackend.Repositories
{
    public class DevoteeRepository : IDevoteeRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly authHelper _authHelper;
        public DevoteeRepository(AppDbContext appDbContext, authHelper authHelper)
        {
            _appDbContext = appDbContext;
            _authHelper = authHelper;
        }

        public async Task<IEnumerable<Devotee>> GetAllDevotees()
        {
            return await _appDbContext.Devotees.ToListAsync();
        }

        public async Task<Devotee?> GetDevoteeById(int Id)
        {
            return await _appDbContext.Devotees.FindAsync(Id);
        }

        public async Task<Devotee> AddDevotee(Devotee devotee)
        {
            var hashPassword = _authHelper.HashPassword(devotee.Password);
            devotee.Password = hashPassword;
            _appDbContext.Devotees.Add(devotee);
            await _appDbContext.SaveChangesAsync();
            return devotee;
        }
    }
}
