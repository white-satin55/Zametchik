
using MediatR;
using Zametchik.Application.Repositories;
using Zametchik.Domain;

namespace Zametchik.Application.CQRS.Queries.Users.GetUserQuery;
internal class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserVm>
{
    private readonly IAsyncReadonlyRepository<UserEntity> _userEntityRepository;

    public GetUserQueryHandler(IAsyncReadonlyRepository<UserEntity> userEntityRepository)
    {
        _userEntityRepository = userEntityRepository;
    }

    public async Task<UserVm> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        return new UserVm();
    }
}
