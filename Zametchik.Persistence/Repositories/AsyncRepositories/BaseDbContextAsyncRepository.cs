using Microsoft.EntityFrameworkCore;

using Zametchik.Application.Repositories;
using Zametchik.Domain;

namespace Zametchik.Persistence.Repositories.AsyncRepositories;

/// <summary>
/// Базовый репозиторий, представляющий обертку для объекта DbContext
/// </summary>
/// <typeparam name="T">Тип доменной сущности</typeparam>
internal abstract class BaseDbContextAsyncRepository<T> : IAsyncRepository<T>
    where T : Entity    
{    
    private readonly ZametchikContext _context;
    protected readonly DbSet<T> _dbSet;

    public BaseDbContextAsyncRepository(ZametchikContext context)
    {
        _context = context; 
        _dbSet = context
            .GetType()
            .GetProperties()
            .First(p => p.PropertyType == typeof(DbSet<T>))
            .GetValue(context) as DbSet<T>;
    }

    public virtual async Task<Guid> AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity.Id;
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<ICollection<T>> GetAllAsync(Func<T, bool> predicate)
    {
        return _dbSet
            .Where(predicate)
            .ToList();
    }

    public virtual async Task<T> GetByIdAsync(Guid id)
    {
        return await _dbSet.FirstAsync(e => e.Id == id);
    }

    public virtual async Task<Guid> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
