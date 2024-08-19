using MediatR;

using Microsoft.AspNetCore.Mvc;

using Zametchik.Application.CQRS.Commands.Users.CreateUserCommand;

namespace Zametchik.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [Route("[action]")]
    public async Task<ActionResult<Guid>> User(CreateUserCommand command)
    {
        var result = await _mediator.Send(command);

        return Ok(result);
    }
}
