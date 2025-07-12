namespace NamingSystem.Core.DbContext;

public class NameIdea
{
    public int Id { get; set; }
    public string Idea { get; set; } = string.Empty;
    public int CreatedByUserId { get; set; }
    public User CreatedBy { get; set; } = null!;
    public ICollection<Reaction> Reactions { get; set; } = [];
}