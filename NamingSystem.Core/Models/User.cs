namespace NamingSystem.Core.DbContext;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public ICollection<NameIdea> NameIdeas { get; set; } = [];
    public ICollection<Reaction> Reactions { get; set; } = [];
}