namespace Zametchik.Application.Repositories;
public interface IAsyncRepository<T> : IAsyncReadonlyRepository<T> where T : class
{
    Task<Guid> Add(T entity);
    Task<Guid> Update(T entity);
    Task Delete(Guid id);
}
