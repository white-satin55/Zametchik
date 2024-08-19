using Zametchik.Domain;

namespace Zametchik.Application.Repositories;
public interface IAsyncRepository<T> : IAsyncReadonlyRepository<T> where T : Entity
{
    Task<Guid> AddAsync(T entity);
    Task<Guid> UpdateAsync(T entity);
    Task DeleteAsync(Guid id);
}
