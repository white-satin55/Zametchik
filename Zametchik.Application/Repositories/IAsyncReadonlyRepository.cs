using Zametchik.Domain;

namespace Zametchik.Application.Repositories;
public interface IAsyncReadonlyRepository<T> where T : Entity
{
    Task<ICollection<T>> GetAllAsync(Func<T, bool> predicate);
    Task<T> GetByIdAsync(Guid id);
}
