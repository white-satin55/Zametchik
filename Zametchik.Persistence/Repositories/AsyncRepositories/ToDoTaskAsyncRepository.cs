using Microsoft.EntityFrameworkCore;
using Zametchik.Application.Repositories;
using Zametchik.Domain;

namespace Zametchik.Persistence.Repositories.AsyncRepositories;
internal class ToDoTaskAsyncRepository : BaseDbContextAsyncRepository<ToDoTaskEntity>
{
    public ToDoTaskAsyncRepository(ZametchikContext context) : base(context)
    {
    }
}
