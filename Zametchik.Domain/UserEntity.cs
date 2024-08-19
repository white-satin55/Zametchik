namespace Zametchik.Domain;

public class UserEntity : Entity
{    
    public Guid UserStatisticGuid { get; set; }
    public string UserName { get; set; } = null!;
    public UserStatisticEntity UserStatistic { get; set; } = null!;
    public ICollection<ToDoTaskEntity> ToDoTasks { get; set; } = null!;
    public ICollection<TagEntity> Tags { get; set; } = null!;
}