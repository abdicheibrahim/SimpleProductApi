using SimpleProductApi.Data.Repositories.Interfaces;

namespace SimpleProductApi.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }

        Task<int> SaveChangesAsync();
    }
}
