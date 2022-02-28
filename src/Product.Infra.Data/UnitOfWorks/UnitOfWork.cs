using Microsoft.EntityFrameworkCore.Storage;
using Product.Infra.Data.Contexts;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace Product.Infra.Data.UnitOfWorks
{
    [ExcludeFromCodeCoverage]
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly ProductDbContext _productDbContext;

        private IDbContextTransaction _transaction;

        public UnitOfWork(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }

        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }

            GC.SuppressFinalize(this);
        }

        public async Task<bool> CommitAsync()
        {
            return await _productDbContext.SaveChangesAsync() == (int)SaveChanges.Commit;
        }

        public async Task BeginTransactionAsync()
        {
            _transaction = await _productDbContext.Database.BeginTransactionAsync();
        }

        public async Task BeginCommitAsync()
        {
            await _transaction.CommitAsync();
        }

        public async Task BeginRollbackAsync()
        {
            await _transaction.RollbackAsync();
        }

        private enum SaveChanges
        {
            Commit = 1
        }
    }
}
