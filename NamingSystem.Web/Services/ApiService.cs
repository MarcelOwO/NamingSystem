using System.Collections;
using System.Net.Http.Json;
using NamingSystem.Core.DbContext;
using NamingSystem.Web.Interfaces;

namespace NamingSystem.Web.Services;

public class ApiService(HttpClient http) : IApiService
{
    public async Task<List<NameIdea>?> ListNameIdeas()
    {
        return await http.GetFromJsonAsync<List<NameIdea>>("NameIdeas");
    }

    public async Task AddUser(User user)
    {
        await http.PostAsJsonAsync("Users", user);
    }

    public async Task AddIdea(NameIdea idea)
    {
    }

    public async Task AddReaction(Reaction reaction)
    {
    }

    public Task<List<NameIdea>> Ideas => await ListNameIdeas();
}