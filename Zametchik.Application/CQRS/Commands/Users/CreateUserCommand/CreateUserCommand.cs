using MediatR;

namespace Zametchik.Application.CQRS.Commands.Users.CreateUserCommand;
public class CreateUserCommand : IRequest<Guid>
{
    public string UserName { get; set; }
}
