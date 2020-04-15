using System.Threading.Tasks;
using FandNCloud.Core;
using FandNCloud.Core.Repositories;
using FandNCloud.Data.Repositories;

namespace FandNCloud.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private IUserRepository _userRepository;

        public UnitOfWork(AppDbContext context)
        {
            this._context = context;
        }
        
        public IUserRepository Users => _userRepository ??= new UserRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}