using MediatR;

namespace Zametchik.Application.CQRS.Commands.ToDoTasks.CreateToDoTaskCommand;
public class CreateToDoTaskCommand : IRequest<Guid>
{
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime? Deadline { get; set; }
    public TimeSpan? AcceptableDelay { get; set; }   
    public CreateToDoTaskCommandPriority Priority { get; set; }
    public Guid[]? TagIds { get; set; }
}

public enum CreateToDoTaskCommandPriority
{
    UrgentImportant = 1,
    UrgentNotImportant = 2,
    NotUrgentImportant = 3,
    NotUrgentNotImportant = 4
}
