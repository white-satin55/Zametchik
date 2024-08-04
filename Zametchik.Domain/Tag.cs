namespace Zametchik.Domain;

public class Tag
{
    public Guid UserId { get; set; }
    public ICollection<Note> Notes { get; set; } = null!;
}