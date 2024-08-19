using Zametchik.Domain;

namespace Zametchik.Application.Repositories;
public interface IReadonlyRepository<T> where T : Entity
{
    ICollection<T> GetAll();
    T GetById(Guid Id);
}
