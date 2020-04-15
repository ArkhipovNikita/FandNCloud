using System;
using System.Threading.Tasks;
using FandNCloud.Core.Repositories;

namespace FandNCloud.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        Task<int> CommitAsync();
    }
}