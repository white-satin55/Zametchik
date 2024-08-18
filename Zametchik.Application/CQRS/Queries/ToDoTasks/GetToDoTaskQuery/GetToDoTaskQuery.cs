using MediatR;

namespace Zametchik.Application.CQRS.Queries.ToDoTasks.GetToDoTaskQuery;
public class GetToDoTaskQuery : IRequest<ToDoTaskVm>
{
    public Guid Id { get; set; }
}
