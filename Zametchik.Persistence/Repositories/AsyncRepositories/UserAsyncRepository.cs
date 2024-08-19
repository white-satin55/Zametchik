using Microsoft.EntityFrameworkCore;

using Zametchik.Application.Repositories;
using Zametchik.Domain;

namespace Zametchik.Persistence.Repositories.AsyncRepositories;
internal class UserAsyncRepository : BaseDbContextAsyncRepository<UserEntity>
{
    public UserAsyncRepository(ZametchikContext context) : base(context)
    {
    }
}
