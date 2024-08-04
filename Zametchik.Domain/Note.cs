namespace Zametchik.Domain;

public class Note
{
    public Guid Id { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime Deadline { get; set; }
    public TimeSpan AcceptableDelay { get; set; }
    public NoteStatus Status { get; set; }
    public NotePriority Priority { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public ICollection<Tag> Tags { get; set; } = null!;
}