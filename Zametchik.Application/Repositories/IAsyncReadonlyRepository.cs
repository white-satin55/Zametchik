namespace Zametchik.Application.Repositories;
public interface IAsyncReadonlyRepository<T> where T : class
{
    Task<ICollection<T>> GetAllAsync();
    Task<T> GetByIdAsync(Guid id);
}
