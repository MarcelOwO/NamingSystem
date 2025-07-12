using NamingSystem.Api.Interfaces;
using NamingSystem.Core.DbContext;

namespace NamingSystem.Api.Endpoints;

public static class EndPoints
{
    public static void MapApiEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/NameIdeas", async (IDbService db) => await db.ListNameIdeas());
        app.MapPost("/Users", async (IDbService db, User user) => await db.AddUser(user));
        app.MapPost("/NameIdeas", async (IDbService db, NameIdea idea) => await db.AddIdea(idea));
        app.MapPost("/Vote", async (IDbService db, Reaction reaction) => await db.AddReaction(reaction));
    }
}