using NamingSystem.Core.DbContext;

namespace NamingSystem.Api.Interfaces;

public interface IDbService
{
    Task<List<NameIdea>> ListNameIdeas();
    Task AddUser(User user);
    Task AddIdea(NameIdea idea);
    Task AddReaction(Reaction reaction);
}