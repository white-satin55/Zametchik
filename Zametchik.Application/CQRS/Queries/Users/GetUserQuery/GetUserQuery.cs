using MediatR;

namespace Zametchik.Application.CQRS.Queries.Users.GetUserQuery;
public class GetUserQuery : IRequest<UserVm>
{
    public Guid Id { get; set; }
}
