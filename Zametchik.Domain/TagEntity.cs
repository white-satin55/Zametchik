namespace Zametchik.Domain;

public class TagEntity : Entity
{    
    public Guid UserId { get; set; }
    public int CompletedToDoTasksCount { get; set; }
    public int ExpiredToDoTasksCount { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public UserEntity User { get; set; } = null!;
    public ICollection<ToDoTaskEntity> ToDoTasks { get; set; } = null!;
}