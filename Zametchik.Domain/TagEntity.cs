namespace Zametchik.Domain;

public class TagEntity
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public UserEntity User { get; set; } = null!;
    public ICollection<ToDoTaskEntity> ToDoTasks { get; set; } = null!;
    public int CompletedToDoTasksCount { get; set; }
    public int ExpiredToDoTasksCount { get; set; }
}