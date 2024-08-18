namespace Zametchik.Application.CQRS.Queries.ToDoTasks.GetToDoTaskQuery;

//TODO: добавить юзера, который последним изменил задачу,
//поскольку будет возможность совместного использования заметок
public class ToDoTaskVm
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Deadline { get; set; }
    public TimeSpan AcceptableDelay { get; set; }
    public ToDoTaskVmStatus Status { get; set; }
    public ToDoTaskVmPriority Priority { get; set; }
    public ToDoTaskVmTag[] Tags { get; set; }
}

class ToDoTaskVmTag
{
    public string Title { get; set; }
}

enum ToDoTaskVmStatus
{
    Active = 1,
    Complete = 2,
    Expired = 3,
    Canceled = 4
}
enum ToDoTaskVmPriority
{
    UrgentImportant = 1,
    UrgentNotImportant = 2,
    NotUrgentImportant = 3,
    NotUrgentNotImportant = 4
}