namespace NamingSystem.Core.DbContext;

public class Reaction
{
    public int UserId { get; set; }
    public User User { get; set; }
    public int NameIdeaID { get; set; }
    public NameIdea NameIdea { get; set; } = null!;
    public ReactionType Type { get; set; }
}