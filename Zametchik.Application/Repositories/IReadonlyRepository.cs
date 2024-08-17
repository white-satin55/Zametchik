namespace Zametchik.Application.Repositories;
public interface IReadonlyRepository<T> where T : class
{
    ICollection<T> GetAll();
    T GetById(Guid Id);
}
