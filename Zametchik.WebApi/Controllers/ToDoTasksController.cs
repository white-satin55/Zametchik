using MediatR;

using Microsoft.AspNetCore.Mvc;

using Zametchik.Application.CQRS.Commands.ToDoTasks.CreateToDoTaskCommand;
using Zametchik.Application.CQRS.Queries.ToDoTasks.GetToDoTaskQuery;

namespace Zametchik.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ToDoTasksController : ControllerBase
{
    private readonly IMediator _mediator;

    public ToDoTasksController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Route("[action]")]
    public async Task<ActionResult> ToDoTask([FromQuery] GetToDoTaskQuery query)
    {
        var toDoTaskVm = await _mediator.Send(query);

        return Ok(toDoTaskVm);
    }

    [HttpPost]
    [Route("[action]")]
    public async Task<ActionResult> ToDoTask(CreateToDoTaskCommand command)
    {
        var id = await _mediator.Send(command);

        return Ok(id);
    }
}
