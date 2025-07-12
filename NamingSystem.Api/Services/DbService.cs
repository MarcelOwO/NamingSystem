using NamingSystem.Api.Interfaces;
using NamingSystem.Core.DbContext;

namespace NamingSystem.Api.Services;

public class DbService(AppDbContext db) : IDbService
{
    public async Task<List<NameIdea>> ListNameIdeas()
    {
        return db.NameIdeas.ToList();
    }
    
    public async Task AddUser(User user)
    {
        db.Users.Add(user);
        await db.SaveChangesAsync();
    }

    public async Task AddIdea(NameIdea idea)
    {
        db.NameIdeas.Add(idea);
        await db.SaveChangesAsync();
    }

    public Task AddReaction(Reaction reaction)
    {
        db.Reactions.Add(reaction);
        return db.SaveChangesAsync();
    }
}