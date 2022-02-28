using System;
using System.Threading.Tasks;

namespace Product.Infra.Data.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> CommitAsync();

        Task BeginTransactionAsync();

        Task BeginCommitAsync();

        Task BeginRollbackAsync();
    }
}
