namespace Zametchik.Application.Repositories;
public interface IRepository<T> : IReadonlyRepository<T> where T : class
{
    Guid Add(T entity);
    Guid Update(T entity);
    void Delete(Guid id);
}
